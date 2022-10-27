using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeShifter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string fileContent = string.Empty;
        public string filePath = string.Empty;

        private void BrowseButton_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Browse Text Files",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "srt files (*.srt)|*.srt|txt files (*.txt)|*.txt|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    fileContent = reader.ReadToEnd();
                }
                
                txtContent.Text = fileContent;
                btnRecalculate.Enabled = true;

                
            }
        }

        private void btnRecalculate_Click(object sender, EventArgs e)
        {
            DoWork();
        }

        public void DoWork()
        {
            int secondsToAdd = int.Parse(txtTimeToAddInSeconds.Text);
            int milisecondsToAdd = int.Parse(txtTimeToAddInMiliseconds.Text);

            foreach (string line in File.ReadLines(filePath))
            {

                bool flag = false;
                string newLine = string.Empty;

                if (line != string.Empty)
                {
                    
                    if (line.Length == 29 && line.Contains(" --> "))
                    {
                        //this could be time
                        //^([0-1]?[0-9]|2[0-3]):[0-5][0-9]$
                        var starting = line.Substring(0, 12);
                        var ending = line.Substring(17, 12);
                        
                        DateTime startTime = DateTime.ParseExact(starting, "HH:mm:ss,fff", CultureInfo.InvariantCulture);
                        DateTime endTIme = DateTime.ParseExact(ending, "HH:mm:ss,fff", CultureInfo.InvariantCulture);

                        startTime = startTime.AddSeconds(secondsToAdd);
                        endTIme = endTIme.AddSeconds(secondsToAdd);

                        startTime = startTime.AddMilliseconds(milisecondsToAdd);
                        endTIme = endTIme.AddMilliseconds(milisecondsToAdd);

                        newLine = startTime.ToString("HH:mm:ss,fff") + " --> " + endTIme.ToString("HH:mm:ss,fff");
                        flag = true;
                    }

                }
                if (flag)
                {
                    if (txtRecalculated.Text == "")
                        txtRecalculated.Text += newLine;
                    else
                    {
                        txtRecalculated.Text += System.Environment.NewLine;
                        txtRecalculated.Text += newLine;
                    }
                }
                else
                {
                    if (txtRecalculated.Text == "")
                        txtRecalculated.Text += line;
                    else
                    {
                        txtRecalculated.Text += System.Environment.NewLine;
                        txtRecalculated.Text += line;
                    }
                }

            }
            btnSave.Enabled = true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Stream myStream;
            //SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            // convert string to stream
            byte[] byteArray = Encoding.ASCII.GetBytes(txtRecalculated.Text);
            MemoryStream stream = new MemoryStream(byteArray);

            // convert stream to string
            StreamReader reader = new StreamReader(stream);
            string text = reader.ReadToEnd();

            saveFileDialog1.Filter = "srt files (*.srt)|*.srt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    stream.Seek(0, SeekOrigin.Begin);
                    stream.CopyTo(myStream);
                    //fileStream.Close();

                    myStream.Close();
                }
                MessageBox.Show("Success", "Completed", MessageBoxButtons.OK);
            }
        }
    }
}
