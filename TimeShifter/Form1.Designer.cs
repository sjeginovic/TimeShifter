namespace TimeShifter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.txtRecalculated = new System.Windows.Forms.TextBox();
            this.btnRecalculate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimeToAddInSeconds = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.txtTimeToAddInMiliseconds = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(22, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(427, 22);
            this.textBox1.TabIndex = 5;
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(478, 30);
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(4);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(173, 33);
            this.BrowseButton.TabIndex = 4;
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(13, 191);
            this.txtContent.Margin = new System.Windows.Forms.Padding(2);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.ReadOnly = true;
            this.txtContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtContent.Size = new System.Drawing.Size(427, 224);
            this.txtContent.TabIndex = 8;
            // 
            // txtRecalculated
            // 
            this.txtRecalculated.Location = new System.Drawing.Point(443, 191);
            this.txtRecalculated.Margin = new System.Windows.Forms.Padding(2);
            this.txtRecalculated.Multiline = true;
            this.txtRecalculated.Name = "txtRecalculated";
            this.txtRecalculated.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecalculated.Size = new System.Drawing.Size(413, 224);
            this.txtRecalculated.TabIndex = 9;
            // 
            // btnRecalculate
            // 
            this.btnRecalculate.Enabled = false;
            this.btnRecalculate.Location = new System.Drawing.Point(697, 146);
            this.btnRecalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnRecalculate.Name = "btnRecalculate";
            this.btnRecalculate.Size = new System.Drawing.Size(159, 35);
            this.btnRecalculate.TabIndex = 10;
            this.btnRecalculate.Text = "Recalculate";
            this.btnRecalculate.UseVisualStyleBackColor = true;
            this.btnRecalculate.Click += new System.EventHandler(this.btnRecalculate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 155);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Add Seconds:";
            // 
            // txtTimeToAddInSeconds
            // 
            this.txtTimeToAddInSeconds.Location = new System.Drawing.Point(500, 152);
            this.txtTimeToAddInSeconds.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeToAddInSeconds.Name = "txtTimeToAddInSeconds";
            this.txtTimeToAddInSeconds.Size = new System.Drawing.Size(33, 22);
            this.txtTimeToAddInSeconds.TabIndex = 12;
            this.txtTimeToAddInSeconds.Text = "30";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(679, 433);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(175, 38);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtTimeToAddInMiliseconds
            // 
            this.txtTimeToAddInMiliseconds.Location = new System.Drawing.Point(655, 151);
            this.txtTimeToAddInMiliseconds.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeToAddInMiliseconds.Name = "txtTimeToAddInMiliseconds";
            this.txtTimeToAddInMiliseconds.Size = new System.Drawing.Size(33, 22);
            this.txtTimeToAddInMiliseconds.TabIndex = 14;
            this.txtTimeToAddInMiliseconds.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(537, 154);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Add miliseconds:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 499);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTimeToAddInMiliseconds);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTimeToAddInSeconds);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRecalculated);
            this.Controls.Add(this.btnRecalculate);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.BrowseButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TimeShifter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.TextBox txtRecalculated;
        private System.Windows.Forms.Button btnRecalculate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeToAddInSeconds;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox txtTimeToAddInMiliseconds;
        private System.Windows.Forms.Label label2;
    }
}

