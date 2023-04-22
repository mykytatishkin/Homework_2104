namespace DuplicateFileFinder
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
            this.btnFindDuplicateFiles = new System.Windows.Forms.Button();
            this.txtSourcePath = new System.Windows.Forms.TextBox();
            this.txtTargetPath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnFindDuplicateFiles
            // 
            this.btnFindDuplicateFiles.Location = new System.Drawing.Point(209, 70);
            this.btnFindDuplicateFiles.Name = "btnFindDuplicateFiles";
            this.btnFindDuplicateFiles.Size = new System.Drawing.Size(132, 33);
            this.btnFindDuplicateFiles.TabIndex = 0;
            this.btnFindDuplicateFiles.Text = "Find Duplicate";
            this.btnFindDuplicateFiles.UseVisualStyleBackColor = true;
            this.btnFindDuplicateFiles.Click += new System.EventHandler(this.btnFindDuplicateFiles_Click);
            // 
            // txtSourcePath
            // 
            this.txtSourcePath.Location = new System.Drawing.Point(12, 12);
            this.txtSourcePath.Name = "txtSourcePath";
            this.txtSourcePath.Size = new System.Drawing.Size(523, 23);
            this.txtSourcePath.TabIndex = 1;
            // 
            // txtTargetPath
            // 
            this.txtTargetPath.Location = new System.Drawing.Point(12, 41);
            this.txtTargetPath.Name = "txtTargetPath";
            this.txtTargetPath.Size = new System.Drawing.Size(523, 23);
            this.txtTargetPath.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 113);
            this.Controls.Add(this.txtTargetPath);
            this.Controls.Add(this.txtSourcePath);
            this.Controls.Add(this.btnFindDuplicateFiles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnFindDuplicateFiles;
        private TextBox txtSourcePath;
        private TextBox txtTargetPath;
    }
}