
namespace PRG282GitQuiz
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
            this.btnRead = new System.Windows.Forms.Button();
            this.lbxFile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(146, 256);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(179, 43);
            this.btnRead.TabIndex = 0;
            this.btnRead.Text = "Read File";
            this.btnRead.UseVisualStyleBackColor = true;
            // 
            // lbxFile
            // 
            this.lbxFile.FormattingEnabled = true;
            this.lbxFile.Location = new System.Drawing.Point(12, 12);
            this.lbxFile.Name = "lbxFile";
            this.lbxFile.Size = new System.Drawing.Size(427, 238);
            this.lbxFile.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 329);
            this.Controls.Add(this.lbxFile);
            this.Controls.Add(this.btnRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.ListBox lbxFile;
    }
}

