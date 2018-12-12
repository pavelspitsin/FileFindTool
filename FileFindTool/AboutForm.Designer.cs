namespace FileFindTool
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sourceCode_link_lbl = new System.Windows.Forms.LinkLabel();
            this.author_lbl = new System.Windows.Forms.Label();
            this.version_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.sourceCode_link_lbl);
            this.panel1.Controls.Add(this.author_lbl);
            this.panel1.Controls.Add(this.version_lbl);
            this.panel1.Controls.Add(this.name_lbl);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 137);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(27, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(69, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // sourceCode_link_lbl
            // 
            this.sourceCode_link_lbl.AutoSize = true;
            this.sourceCode_link_lbl.Location = new System.Drawing.Point(114, 96);
            this.sourceCode_link_lbl.Name = "sourceCode_link_lbl";
            this.sourceCode_link_lbl.Size = new System.Drawing.Size(68, 13);
            this.sourceCode_link_lbl.TabIndex = 3;
            this.sourceCode_link_lbl.TabStop = true;
            this.sourceCode_link_lbl.Text = "Source code";
            this.sourceCode_link_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.sourceCode_link_lbl_LinkClicked);
            // 
            // author_lbl
            // 
            this.author_lbl.AutoSize = true;
            this.author_lbl.Location = new System.Drawing.Point(114, 74);
            this.author_lbl.Name = "author_lbl";
            this.author_lbl.Size = new System.Drawing.Size(115, 13);
            this.author_lbl.TabIndex = 2;
            this.author_lbl.Text = "Автор: Спицин Павел";
            // 
            // version_lbl
            // 
            this.version_lbl.AutoSize = true;
            this.version_lbl.Location = new System.Drawing.Point(114, 51);
            this.version_lbl.Name = "version_lbl";
            this.version_lbl.Size = new System.Drawing.Size(43, 13);
            this.version_lbl.TabIndex = 1;
            this.version_lbl.Text = "ver. 1.1";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name_lbl.Location = new System.Drawing.Point(63, 9);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(103, 20);
            this.name_lbl.TabIndex = 0;
            this.name_lbl.Text = "File Find Tool";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 161);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel sourceCode_link_lbl;
        private System.Windows.Forms.Label author_lbl;
        private System.Windows.Forms.Label version_lbl;
        private System.Windows.Forms.Label name_lbl;
    }
}