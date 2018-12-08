namespace FileFindTool
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFolder_textBox = new System.Windows.Forms.TextBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.result_listBox = new System.Windows.Forms.ListBox();
            this.result_listBox_contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.OpenMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWithMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OpenExplorerMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyPathMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchText_textBox = new System.Windows.Forms.TextBox();
            this.searchText_label = new System.Windows.Forms.Label();
            this.find_btn = new System.Windows.Forms.Button();
            this.pause_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.currentFile_label = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.fileType_label = new System.Windows.Forms.Label();
            this.allDirectories_checkBox = new System.Windows.Forms.CheckBox();
            this.fileType_comboBox = new System.Windows.Forms.ComboBox();
            this.OpenWithNotepadPlusPlus = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWithNotepad = new System.Windows.Forms.ToolStripMenuItem();
            this.result_listBox_contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFolder_textBox
            // 
            this.openFolder_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.openFolder_textBox.Location = new System.Drawing.Point(518, 12);
            this.openFolder_textBox.Name = "openFolder_textBox";
            this.openFolder_textBox.Size = new System.Drawing.Size(362, 20);
            this.openFolder_textBox.TabIndex = 0;
            // 
            // open_btn
            // 
            this.open_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.open_btn.Location = new System.Drawing.Point(886, 11);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(86, 23);
            this.open_btn.TabIndex = 1;
            this.open_btn.Text = "Открыть";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // result_listBox
            // 
            this.result_listBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.result_listBox.ContextMenuStrip = this.result_listBox_contextMenuStrip;
            this.result_listBox.FormattingEnabled = true;
            this.result_listBox.HorizontalScrollbar = true;
            this.result_listBox.Location = new System.Drawing.Point(12, 12);
            this.result_listBox.Name = "result_listBox";
            this.result_listBox.Size = new System.Drawing.Size(500, 433);
            this.result_listBox.TabIndex = 11;
            this.result_listBox.DoubleClick += new System.EventHandler(this.result_listBox_DoubleClick);
            // 
            // result_listBox_contextMenuStrip
            // 
            this.result_listBox_contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenMenuItem,
            this.OpenWithNotepad,
            this.OpenWithNotepadPlusPlus,
            this.OpenWithMenuItem,
            this.toolStripSeparator1,
            this.OpenExplorerMenuItem,
            this.CopyPathMenuItem});
            this.result_listBox_contextMenuStrip.Name = "result_listBox_contextMenuStrip";
            this.result_listBox_contextMenuStrip.Size = new System.Drawing.Size(200, 164);
            this.result_listBox_contextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.result_listBox_contextMenuStrip_Opening);
            // 
            // OpenMenuItem
            // 
            this.OpenMenuItem.Name = "OpenMenuItem";
            this.OpenMenuItem.Size = new System.Drawing.Size(199, 22);
            this.OpenMenuItem.Text = "Открыть";
            this.OpenMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // OpenWithMenuItem
            // 
            this.OpenWithMenuItem.Name = "OpenWithMenuItem";
            this.OpenWithMenuItem.Size = new System.Drawing.Size(199, 22);
            this.OpenWithMenuItem.Text = "Открыть с помощью...";
            this.OpenWithMenuItem.Click += new System.EventHandler(this.OpenWithMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(196, 6);
            // 
            // OpenExplorerMenuItem
            // 
            this.OpenExplorerMenuItem.Name = "OpenExplorerMenuItem";
            this.OpenExplorerMenuItem.Size = new System.Drawing.Size(199, 22);
            this.OpenExplorerMenuItem.Text = "Расположение файла";
            this.OpenExplorerMenuItem.Click += new System.EventHandler(this.OpenExplorerMenuItem_Click);
            // 
            // CopyPathMenuItem
            // 
            this.CopyPathMenuItem.Name = "CopyPathMenuItem";
            this.CopyPathMenuItem.Size = new System.Drawing.Size(199, 22);
            this.CopyPathMenuItem.Text = "Копировать путь";
            this.CopyPathMenuItem.Click += new System.EventHandler(this.CopyPathMenuItem_Click);
            // 
            // searchText_textBox
            // 
            this.searchText_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText_textBox.Location = new System.Drawing.Point(518, 127);
            this.searchText_textBox.Multiline = true;
            this.searchText_textBox.Name = "searchText_textBox";
            this.searchText_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.searchText_textBox.Size = new System.Drawing.Size(362, 81);
            this.searchText_textBox.TabIndex = 6;
            // 
            // searchText_label
            // 
            this.searchText_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.searchText_label.AutoSize = true;
            this.searchText_label.Location = new System.Drawing.Point(515, 107);
            this.searchText_label.Name = "searchText_label";
            this.searchText_label.Size = new System.Drawing.Size(89, 13);
            this.searchText_label.TabIndex = 5;
            this.searchText_label.Text = "Искомый текст:";
            // 
            // find_btn
            // 
            this.find_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.find_btn.Location = new System.Drawing.Point(886, 129);
            this.find_btn.Name = "find_btn";
            this.find_btn.Size = new System.Drawing.Size(86, 23);
            this.find_btn.TabIndex = 7;
            this.find_btn.Text = "Найти";
            this.find_btn.UseVisualStyleBackColor = true;
            this.find_btn.Click += new System.EventHandler(this.find_btn_Click);
            // 
            // pause_btn
            // 
            this.pause_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pause_btn.Enabled = false;
            this.pause_btn.Location = new System.Drawing.Point(886, 158);
            this.pause_btn.Name = "pause_btn";
            this.pause_btn.Size = new System.Drawing.Size(86, 23);
            this.pause_btn.TabIndex = 8;
            this.pause_btn.Text = "Пауза";
            this.pause_btn.UseVisualStyleBackColor = true;
            this.pause_btn.Click += new System.EventHandler(this.pause_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.stop_btn.Enabled = false;
            this.stop_btn.Location = new System.Drawing.Point(886, 187);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(86, 23);
            this.stop_btn.TabIndex = 9;
            this.stop_btn.Text = "Остановить";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // currentFile_label
            // 
            this.currentFile_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentFile_label.AutoSize = true;
            this.currentFile_label.Location = new System.Drawing.Point(518, 432);
            this.currentFile_label.Name = "currentFile_label";
            this.currentFile_label.Size = new System.Drawing.Size(0, 13);
            this.currentFile_label.TabIndex = 10;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // fileType_label
            // 
            this.fileType_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileType_label.AutoSize = true;
            this.fileType_label.Location = new System.Drawing.Point(515, 48);
            this.fileType_label.Name = "fileType_label";
            this.fileType_label.Size = new System.Drawing.Size(64, 13);
            this.fileType_label.TabIndex = 2;
            this.fileType_label.Text = "Тип файла:";
            // 
            // allDirectories_checkBox
            // 
            this.allDirectories_checkBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.allDirectories_checkBox.AutoSize = true;
            this.allDirectories_checkBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.allDirectories_checkBox.Checked = true;
            this.allDirectories_checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.allDirectories_checkBox.Location = new System.Drawing.Point(801, 48);
            this.allDirectories_checkBox.Name = "allDirectories_checkBox";
            this.allDirectories_checkBox.Size = new System.Drawing.Size(171, 17);
            this.allDirectories_checkBox.TabIndex = 3;
            this.allDirectories_checkBox.Text = "Поиск во вложенных папках";
            this.allDirectories_checkBox.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.allDirectories_checkBox.UseVisualStyleBackColor = true;
            // 
            // fileType_comboBox
            // 
            this.fileType_comboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fileType_comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileType_comboBox.Location = new System.Drawing.Point(518, 70);
            this.fileType_comboBox.Name = "fileType_comboBox";
            this.fileType_comboBox.Size = new System.Drawing.Size(454, 21);
            this.fileType_comboBox.TabIndex = 4;
            // 
            // OpenWithNotepadPlusPlus
            // 
            this.OpenWithNotepadPlusPlus.Name = "OpenWithNotepadPlusPlus";
            this.OpenWithNotepadPlusPlus.Size = new System.Drawing.Size(199, 22);
            this.OpenWithNotepadPlusPlus.Text = "Edit with Notepad++";
            this.OpenWithNotepadPlusPlus.Click += new System.EventHandler(this.OpenWithNotepadPlusPlus_Click);
            // 
            // OpenWithNotepad
            // 
            this.OpenWithNotepad.Name = "OpenWithNotepad";
            this.OpenWithNotepad.Size = new System.Drawing.Size(199, 22);
            this.OpenWithNotepad.Text = "Блокнот";
            this.OpenWithNotepad.Click += new System.EventHandler(this.OpenWithNotepad_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.fileType_comboBox);
            this.Controls.Add(this.allDirectories_checkBox);
            this.Controls.Add(this.fileType_label);
            this.Controls.Add(this.currentFile_label);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.pause_btn);
            this.Controls.Add(this.find_btn);
            this.Controls.Add(this.searchText_label);
            this.Controls.Add(this.searchText_textBox);
            this.Controls.Add(this.result_listBox);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.openFolder_textBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Find Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.result_listBox_contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox openFolder_textBox;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.ListBox result_listBox;
        private System.Windows.Forms.TextBox searchText_textBox;
        private System.Windows.Forms.Label searchText_label;
        private System.Windows.Forms.Button find_btn;
        private System.Windows.Forms.Button pause_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Label currentFile_label;
        internal System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label fileType_label;
        private System.Windows.Forms.CheckBox allDirectories_checkBox;
        private System.Windows.Forms.ComboBox fileType_comboBox;
        private System.Windows.Forms.ContextMenuStrip result_listBox_contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem OpenMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenWithMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OpenExplorerMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyPathMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenWithNotepad;
        private System.Windows.Forms.ToolStripMenuItem OpenWithNotepadPlusPlus;
    }
}

