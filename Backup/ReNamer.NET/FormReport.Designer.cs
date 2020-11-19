namespace Files_Renamer.NET
{
    partial class FormReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReport));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelCopied = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.labelDir = new System.Windows.Forms.Label();
            this.buttonDir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMoved = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelOverwrited = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResized = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Files :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copied Files :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTotal
            // 
            this.labelTotal.Location = new System.Drawing.Point(149, 9);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(78, 20);
            this.labelTotal.TabIndex = 2;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCopied
            // 
            this.labelCopied.Location = new System.Drawing.Point(149, 31);
            this.labelCopied.Name = "labelCopied";
            this.labelCopied.Size = new System.Drawing.Size(78, 20);
            this.labelCopied.TabIndex = 3;
            this.labelCopied.Text = "0";
            this.labelCopied.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(308, 178);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(102, 29);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // labelDir
            // 
            this.labelDir.Location = new System.Drawing.Point(178, 132);
            this.labelDir.Name = "labelDir";
            this.labelDir.Size = new System.Drawing.Size(232, 36);
            this.labelDir.TabIndex = 6;
            this.labelDir.Text = "\\\\";
            // 
            // buttonDir
            // 
            this.buttonDir.Location = new System.Drawing.Point(58, 128);
            this.buttonDir.Name = "buttonDir";
            this.buttonDir.Size = new System.Drawing.Size(114, 23);
            this.buttonDir.TabIndex = 7;
            this.buttonDir.Text = "Destination Directory";
            this.buttonDir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDir.UseVisualStyleBackColor = true;
            this.buttonDir.Click += new System.EventHandler(this.buttonDir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelMoved
            // 
            this.labelMoved.Location = new System.Drawing.Point(149, 54);
            this.labelMoved.Name = "labelMoved";
            this.labelMoved.Size = new System.Drawing.Size(78, 20);
            this.labelMoved.TabIndex = 10;
            this.labelMoved.Text = "0";
            this.labelMoved.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(55, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Moved Files :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelOverwrited
            // 
            this.labelOverwrited.Location = new System.Drawing.Point(149, 100);
            this.labelOverwrited.Name = "labelOverwrited";
            this.labelOverwrited.Size = new System.Drawing.Size(78, 20);
            this.labelOverwrited.TabIndex = 12;
            this.labelOverwrited.Text = "0";
            this.labelOverwrited.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(55, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Overwrited Files :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelResized
            // 
            this.labelResized.Location = new System.Drawing.Point(149, 77);
            this.labelResized.Name = "labelResized";
            this.labelResized.Size = new System.Drawing.Size(163, 20);
            this.labelResized.TabIndex = 14;
            this.labelResized.Text = "0";
            this.labelResized.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(55, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Risized Images :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 213);
            this.Controls.Add(this.labelResized);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelOverwrited);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelMoved);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDir);
            this.Controls.Add(this.labelDir);
            this.Controls.Add(this.labelCopied);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Operation Report";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelCopied;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Label labelDir;
        private System.Windows.Forms.Button buttonDir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelMoved;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOverwrited;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResized;
        private System.Windows.Forms.Label label6;
    }
}