using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using FileFindTool.Utils;

namespace FileFindTool
{
    internal enum SearchState
    {
        Stopped,
        OnPause,
        InProcess
    };

    public partial class MainForm : Form
    {
        private FilesEnumerator _filesEnumerator = null;
        private SearchState _searchState = SearchState.Stopped;

        public MainForm()
        {
            InitializeComponent();
            InitializeFileTypesCombobox();

            fileType_comboBox.GotFocus += fileType_comboBox_OnFocus;
            toolStripStatusLabel.Text = "";
            OpenWithNotepadPlusPlus.Enabled = NotepadPluPlusHelper.IsInstalled();
        }


        #region private methods

        private void ChangeButtons(SearchState state)
        {
            switch (state)
            {
                case SearchState.InProcess:
                    find_btn.Text = "Найти";
                    find_btn.Enabled = false;
                    pause_btn.Enabled = true;
                    stop_btn.Enabled = true;
                    open_btn.Enabled = false;
                    openFolder_textBox.Enabled = false;
                    fileType_comboBox.Enabled = false;
                    searchText_textBox.Enabled = false;
                    break;
                case SearchState.OnPause:
                    find_btn.Text = "Продолжить";
                    find_btn.Enabled = true;
                    pause_btn.Enabled = false;
                    stop_btn.Enabled = true;
                    open_btn.Enabled = false;
                    openFolder_textBox.Enabled = false;
                    fileType_comboBox.Enabled = false;
                    searchText_textBox.Enabled = false;
                    break;
                case SearchState.Stopped:
                    find_btn.Text = "Найти";
                    find_btn.Enabled = true;
                    pause_btn.Enabled = false;
                    stop_btn.Enabled = false;
                    open_btn.Enabled = true;
                    openFolder_textBox.Enabled = true;
                    fileType_comboBox.Enabled = true;
                    searchText_textBox.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void DisposeFilesEnumerator()
        {
            if (_filesEnumerator != null)
            {
                _filesEnumerator.Dispose();
                _filesEnumerator = null;
            }
        }

        private void InitializeFileTypesCombobox()
        {
            fileType_comboBox.Text = Config.DefaultFileType;

            string[] fileTypes = Config.FileTypes.Split(';').Where(str => str.Length > 0).ToArray();

            foreach (string fileType in fileTypes)
            {
                fileType_comboBox.Items.Add(fileType);
            }
        }

        private string GetSelectedFilePath()
        {
            return result_listBox.Items[result_listBox.SelectedIndex].ToString();
        }

        #endregion


        #region event handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            //this.ActiveControl = searchText_textBox;
        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog dlg = new CommonOpenFileDialog();
            dlg.IsFolderPicker = true;
            CommonFileDialogResult result = dlg.ShowDialog();

            if (result == CommonFileDialogResult.Ok)
            {
                openFolder_textBox.Text = dlg.FileName;
                toolStripStatusLabel.Text = "";
            }
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            string searchText = searchText_textBox.Text.Trim();
            string searchPattern = fileType_comboBox.Text.Trim();
            string path = openFolder_textBox.Text.Trim();


            if (_searchState == SearchState.Stopped)
            {
                if (!Directory.Exists(path))
                {
                    MessageBox.Show("Пожалуйста, укажите корректный путь.");
                    this.ActiveControl = openFolder_textBox;
                    return;
                }

                if (searchText.Length == 0)
                {
                    MessageBox.Show("Пожалуйста, укажите текст для поиска.");
                    this.ActiveControl = searchText_textBox;
                    return;
                }


                DisposeFilesEnumerator();

                try
                {
                    _filesEnumerator = new FilesEnumerator(path, searchPattern, allDirectories_checkBox.Checked ?
                                                                                SearchOption.AllDirectories :
                                                                                SearchOption.TopDirectoryOnly
                    );
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
            

            if (backgroundWorker.IsBusy != true)
            {
                backgroundWorker.RunWorkerAsync(searchText);
            }

            _searchState = SearchState.InProcess;
            ChangeButtons(_searchState);
            toolStripStatusLabel.Text = "Search...";
        }

        private void pause_btn_Click(object sender, EventArgs e)
        {
            _searchState = SearchState.OnPause;
            ChangeButtons(_searchState);

            if (backgroundWorker.WorkerSupportsCancellation == true)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            _searchState = SearchState.Stopped;
            ChangeButtons(_searchState);

            if (backgroundWorker.WorkerSupportsCancellation == true)
            {
                backgroundWorker.CancelAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (_filesEnumerator == null)
                return;
            
            string filePath = _filesEnumerator.GetNext();
            List<string> files = new List<string>();

            while (filePath != null)
            {
                if (backgroundWorker.CancellationPending == true)
                {
                    e.Result = files.ToArray();
                    return;
                }

                string searchText = e.Argument.ToString();

                if (FileChecker.Contains(filePath, searchText))
                {
                    files.Add(filePath);
                }

                filePath = _filesEnumerator.GetNext();
            }
            e.Result = files.ToArray();
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)                                // Error
            {
                MessageBox.Show(e.Error.Message);
            }
            else if (_searchState == SearchState.OnPause)       // On pause
            {                
                toolStripStatusLabel.Text = "Pause";

                var result = e.Result as string[];
                if (result != null)
                {
                    result_listBox.Items.Clear();
                    result_listBox.Items.AddRange(result);
                }
            }
            else if (_searchState == SearchState.Stopped)       // Stopped
            {                
                toolStripStatusLabel.Text = "";
                DisposeFilesEnumerator();
            }
            else if (_searchState == SearchState.InProcess)     //Done
            {                
                toolStripStatusLabel.Text = "Complete";

                _searchState = SearchState.Stopped;
                ChangeButtons(_searchState);

                var result = e.Result as string[];
                if (result != null)
                {
                    result_listBox.Items.Clear();
                    result_listBox.Items.AddRange(result);
                }
                DisposeFilesEnumerator();
            }
        }

        private void result_listBox_DoubleClick(object sender, EventArgs e)
        {
            if (result_listBox.SelectedIndex != -1)
            {
                string filePath = GetSelectedFilePath();
                System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
            }
        }

        private void fileType_comboBox_OnFocus(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox == null)
                return;

            // Don't select text in the combobox
            comboBox.Select(comboBox.Text.Length, 0);
        }


        private void result_listBox_contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            if (result_listBox.SelectedIndex == -1)
            {
                e.Cancel = true;
                return;
            }
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm form = new AboutForm();
            form.ShowDialog(this);
        }

        #endregion


        #region context menu event handlers

        private void OpenMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = GetSelectedFilePath();
            System.Diagnostics.Process.Start(filePath);
        }

        private void OpenWithNotepad_Click(object sender, EventArgs e)
        {
            string filePath = GetSelectedFilePath();
            System.Diagnostics.Process.Start("notepad.exe", filePath);
        }

        private void OpenWithNotepadPlusPlus_Click(object sender, EventArgs e)
        {
            string filePath = GetSelectedFilePath();
            System.Diagnostics.Process.Start("notepad++.exe", string.Format("\"{0}\"", filePath));
        }

        private void OpenWithMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = GetSelectedFilePath();
            RunDLL32Helper.ShowOpenWithDialog(filePath);
        }

        private void OpenExplorerMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = GetSelectedFilePath();
            System.Diagnostics.Process.Start("explorer.exe", string.Format("/select,\"{0}\"", filePath));
        }

        private void CopyPathMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = GetSelectedFilePath();
            Clipboard.SetText(filePath);
        }

        #endregion

    }
}
