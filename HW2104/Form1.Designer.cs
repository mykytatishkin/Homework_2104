namespace HW2104
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.checkBoxChar = new System.Windows.Forms.CheckBox();
            this.checkBoxWords = new System.Windows.Forms.CheckBox();
            this.checkBoxSent = new System.Windows.Forms.CheckBox();
            this.checkBoxAttent = new System.Windows.Forms.CheckBox();
            this.checkBoxQuest = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 23);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter text";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 60);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(622, 199);
            this.listBox1.TabIndex = 2;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(474, 23);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(559, 23);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // checkBoxChar
            // 
            this.checkBoxChar.AutoSize = true;
            this.checkBoxChar.Location = new System.Drawing.Point(653, 62);
            this.checkBoxChar.Name = "checkBoxChar";
            this.checkBoxChar.Size = new System.Drawing.Size(82, 19);
            this.checkBoxChar.TabIndex = 5;
            this.checkBoxChar.Text = "Charecters";
            this.checkBoxChar.UseVisualStyleBackColor = true;
            // 
            // checkBoxWords
            // 
            this.checkBoxWords.AutoSize = true;
            this.checkBoxWords.Location = new System.Drawing.Point(653, 87);
            this.checkBoxWords.Name = "checkBoxWords";
            this.checkBoxWords.Size = new System.Drawing.Size(60, 19);
            this.checkBoxWords.TabIndex = 6;
            this.checkBoxWords.Text = "Words";
            this.checkBoxWords.UseVisualStyleBackColor = true;
            // 
            // checkBoxSent
            // 
            this.checkBoxSent.AutoSize = true;
            this.checkBoxSent.Location = new System.Drawing.Point(653, 112);
            this.checkBoxSent.Name = "checkBoxSent";
            this.checkBoxSent.Size = new System.Drawing.Size(79, 19);
            this.checkBoxSent.TabIndex = 7;
            this.checkBoxSent.Text = "Sentences";
            this.checkBoxSent.UseVisualStyleBackColor = true;
            // 
            // checkBoxAttent
            // 
            this.checkBoxAttent.AutoSize = true;
            this.checkBoxAttent.Location = new System.Drawing.Point(653, 137);
            this.checkBoxAttent.Name = "checkBoxAttent";
            this.checkBoxAttent.Size = new System.Drawing.Size(132, 19);
            this.checkBoxAttent.TabIndex = 8;
            this.checkBoxAttent.Text = "Attention Sentences";
            this.checkBoxAttent.UseVisualStyleBackColor = true;
            // 
            // checkBoxQuest
            // 
            this.checkBoxQuest.AutoSize = true;
            this.checkBoxQuest.Location = new System.Drawing.Point(653, 162);
            this.checkBoxQuest.Name = "checkBoxQuest";
            this.checkBoxQuest.Size = new System.Drawing.Size(130, 19);
            this.checkBoxQuest.TabIndex = 9;
            this.checkBoxQuest.Text = "Question Sentences";
            this.checkBoxQuest.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 269);
            this.Controls.Add(this.checkBoxQuest);
            this.Controls.Add(this.checkBoxAttent);
            this.Controls.Add(this.checkBoxSent);
            this.Controls.Add(this.checkBoxWords);
            this.Controls.Add(this.checkBoxChar);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ListBox listBox1;
        private Button startButton;
        private Button stopButton;
        private CheckBox checkBoxChar;
        private CheckBox checkBoxWords;
        private CheckBox checkBoxSent;
        private CheckBox checkBoxAttent;
        private CheckBox checkBoxQuest;
    }
}