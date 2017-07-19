using BackUpFilesSingle.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackUpFilesSingle
{
    public partial class FormBackupAssistant : System.Windows.Forms.Form
    {
        private System.Collections.Specialized.StringCollection folderColA;
        private System.Collections.Specialized.StringCollection folderColB;
        private bool finished;
        private Thread thread;

        public FormBackupAssistant()
        {
            InitializeComponent();
            InitializeFormText();

            finished = true;
            folderColA = new System.Collections.Specialized.StringCollection();
            folderColB = new System.Collections.Specialized.StringCollection();

            CreateHeaderAndFillListView();
            LoadSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!finished)
            {
                MessageBox.Show(StringValues.formClosingBody, StringValues.formClosingTitle, MessageBoxButtons.OK);
                e.Cancel = true;
            }

            SaveSettings();
        }

        private void InitializeFormText()
        {
            this.Text = StringValues.formText;
            labelFolderA.Text = StringValues.labelFolderAText;
            labelFolderB.Text = StringValues.labelFolderBText;
            labelScanning.Text = StringValues.labelScanningText;
            groupBoxDetail.Text = StringValues.groupBoxDetailText;
            groupBoxViewMode.Text = StringValues.groupBoxViewModeText;
            radioButtonLargeIcon.Text = StringValues.radioButtionLargeIconText;
            radioButtonSmallIcon.Text = StringValues.radioButtionSmallIconText;
            radioButtonList.Text = StringValues.radioButtionListText;
            radioButtonDetails.Text = StringValues.radioButtionDetailsText;
            radioButtonTile.Text = StringValues.radioButtionTileText;
            buttonBackA.Text = StringValues.buttonBackText;
            buttonBackB.Text = StringValues.buttonBackText;
            buttonGoUpA.Text = StringValues.buttonGoUpText;
            buttonGoUpB.Text = StringValues.buttonGoUpText;
            buttonRefreshA.Text = StringValues.buttonRefreshText;
            buttonRefreshB.Text = StringValues.buttonRefreshText;
            buttonOpenA.Text = StringValues.buttonOpenText;
            buttonOpenB.Text = StringValues.buttonOpenText;
            buttonAbort.Text = StringValues.buttonAbortText;
            buttonClear.Text = StringValues.buttonClearText;

            this.Refresh();
        }

        private void CreateHeaderAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = StringValues.colHeadFileName;
            colHead.Width = 120;
            listViewA.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = StringValues.colHeadFileName;
            colHead.Width = 120;
            listViewB.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = StringValues.colHeadSize;
            colHead.Width = 120;
            listViewA.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = StringValues.colHeadSize;
            colHead.Width = 120;
            listViewB.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = StringValues.colHeadLastAccess;
            colHead.Width = 120;
            listViewA.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = StringValues.colHeadLastAccess;
            colHead.Width = 120;
            listViewB.Columns.Add(colHead); // Insert the header
        }

        private void PaintListViewA(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (string.IsNullOrEmpty(root))
                    return;

                // Get information about the root folder.
                DirectoryInfo dir = new DirectoryInfo(root);
                // Retrieve the files and folders from the root folder.
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                listViewA.Items.Clear();
                textBoxPathA.Text = root;
                listViewA.BeginUpdate();

                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    listViewA.Items.Add(lvi);
                }

                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    listViewA.Items.Add(lvi);
                }

                listViewA.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PaintListViewB(string root)
        {
            try
            {
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                if (string.IsNullOrEmpty(root))
                    return;

                // Get information about the root folder.
                DirectoryInfo dir = new DirectoryInfo(root);
                // Retrieve the files and folders from the root folder.
                DirectoryInfo[] dirs = dir.GetDirectories();
                FileInfo[] files = dir.GetFiles();

                listViewB.Items.Clear();
                textBoxPathB.Text = root;
                listViewB.BeginUpdate();

                foreach (DirectoryInfo di in dirs)
                {
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;
                    lvi.ImageIndex = 0;
                    lvi.Tag = di.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    listViewB.Items.Add(lvi);
                }

                foreach (FileInfo fi in files)
                {
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name;
                    lvi.ImageIndex = 1;
                    lvi.Tag = fi.FullName;

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();
                    lvi.SubItems.Add(lvsi);

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();
                    lvi.SubItems.Add(lvsi);

                    listViewB.Items.Add(lvi);
                }

                listViewB.EndUpdate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RadioButtonLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.LargeIcon;
                this.listViewB.View = View.LargeIcon;
            }
        }

        private void RadioButtonSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.SmallIcon;
                this.listViewB.View = View.SmallIcon;
            }
        }

        private void RadioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.List;
                this.listViewB.View = View.List;
            }
        }

        private void RadioButtonDetails_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.Details;
                this.listViewB.View = View.Details;
            }
        }

        private void RadioButtonTile_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.Tile;
                this.listViewB.View = View.Tile;
            }
        }

        private void ListViewA_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex == 0)
            {
                PaintListViewA(filename);
                folderColA.Add(filename);
            }
        }

        private void ListViewB_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex == 0)
            {
                PaintListViewB(filename);
                folderColB.Add(filename);
            }
        }

        private void ButtonOpenA_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = StringValues.folderBrowserDialogDescription })
            {
                if (folderColA.Count > 0)
                    fbd.SelectedPath = folderColA[folderColA.Count - 1];

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    PaintListViewA(fbd.SelectedPath);
                    folderColA.Add(fbd.SelectedPath);
                }
            }
        }

        private void ButtonOpenB_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = StringValues.folderBrowserDialogDescription })
            {
                if (folderColB.Count > 0)
                    fbd.SelectedPath = folderColB[folderColB.Count - 1];

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    PaintListViewB(fbd.SelectedPath);
                    folderColB.Add(fbd.SelectedPath);
                }
            }
        }

        private void ButtonBackA_Click(object sender, EventArgs e)
        {
            if (folderColA.Count > 1)
            {
                PaintListViewA(folderColA[folderColA.Count - 2].ToString());
                folderColA.RemoveAt(folderColA.Count - 1);
            }
            else
                PaintListViewA(folderColA[0].ToString());
        }

        private void ButtonBackB_Click(object sender, EventArgs e)
        {
            if (folderColB.Count > 1)
            {
                PaintListViewB(folderColB[folderColB.Count - 2].ToString());
                folderColB.RemoveAt(folderColB.Count - 1);
            }
            else
                PaintListViewB(folderColB[0].ToString());
        }

        private void ButtonGoUpA_Click(object sender, EventArgs e)
        {
            string path = textBoxPathA.Text;
            string[] s = path.Split('\\');

            if (s.Length == 1)
                return;

            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);

            if (s.Length == 2)
                sb.Append('\\');
            else
            {
                for (int i = 1; i < s.Length - 1; i++)
                    sb.Append('\\').Append(s[i]);
            }

            PaintListViewA(sb.ToString());
            folderColA.Add(sb.ToString());
        }

        private void ButtonGoUpB_Click(object sender, EventArgs e)
        {
            string path = textBoxPathB.Text;
            string[] s = path.Split('\\');

            if (s.Length == 1)
                return;

            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);

            if (s.Length == 2)
                sb.Append('\\');
            else
            {
                for (int i = 1; i < s.Length - 1; i++)
                    sb.Append('\\').Append(s[i]);
            }

            PaintListViewB(sb.ToString());
            folderColB.Add(sb.ToString());
        }

        private void ButtonRefreshA_Click(object sender, EventArgs e)
        {
            RefreshA();
        }

        private void ButtonRefreshB_Click(object sender, EventArgs e)
        {
            RefreshB();
        }

        private void ButtonAToB_Click(object sender, EventArgs e)
        {
            string source = folderColA[folderColA.Count - 1];
            string target = folderColB[folderColB.Count - 1];
            BeforeStart(source, target);
        }

        private void ButtonBToA_Click(object sender, EventArgs e)
        {
            string source = folderColB[folderColB.Count - 1];
            string target = folderColA[folderColA.Count - 1];
            BeforeStart(source, target);
        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            if (finished)
                return;

            thread.Abort();

            AddToListBox(StringValues.syncAborted);
            UpdateLabel(StringValues.empty);
            SetButtons(true);
            finished = true;

            RefreshA();
            RefreshB();
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void RefreshA()
        {
            BeginInvoke(new Action(() =>
            {
                PaintListViewA(textBoxPathA.Text);
            }));            
        }

        private void RefreshB()
        {
            BeginInvoke(new Action(() =>
            {
                PaintListViewB(textBoxPathB.Text);
            }));
        }

        private void BeforeStart(string source, string target)
        {
            string title = StringValues.beforeSyncTitle;
            string body = string.Format(StringValues.beforeSyncBodyFormat, source, target);

            DialogResult result = MessageBox.Show(body, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            SetButtons(false);
            finished = false;
            AddToListBox(StringValues.syncStart);
            
            ParameterizedThreadStart pts = new ParameterizedThreadStart(StartSync);
            thread = new Thread(pts);
            Pair pair = new Pair(source, target);
            thread.Start(pair);
        }

        private void StartSync(object o)
        {
            Pair pair = (Pair)o;
            Queue<Pair> folderQueue = new Queue<Pair>();
            folderQueue.Enqueue(pair);

            while (folderQueue.Count != 0)
            {
                Pair p = folderQueue.Dequeue();
                string source = p.source;
                string target = p.target;

                HashSet<string> sourceFileSet;
                HashSet<string> sourceDirSet;
                HashSet<string> targetFileSet;
                HashSet<string> targetDirSet;
                MakeSets(source, out sourceFileSet, out sourceDirSet);
                MakeSets(target, out targetFileSet, out targetDirSet);

                SyncFiles(source, target, sourceFileSet, targetFileSet);
                SyncFolders(source, target, sourceDirSet, targetDirSet, folderQueue);
            }

            AddToListBox(StringValues.syncFinished);
            UpdateLabel(StringValues.empty);
            SetButtons(true);
            finished = true;

            RefreshA();
            RefreshB();
        }

        private void MakeSets(string path, out HashSet<string> fileSet, out HashSet<string> dirSet)
        {
            string[] paths = Directory.GetFiles(path);
            fileSet = new HashSet<string>();
            foreach (string s in paths)
            {
                string[] ss = s.Split('\\');
                fileSet.Add(ss[ss.Length - 1]);
            }

            paths = Directory.GetDirectories(path);
            dirSet = new HashSet<string>();
            foreach (string s in paths)
            {
                string[] ss = s.Split('\\');
                dirSet.Add(ss[ss.Length - 1]);
            }
        }

        private void SyncFiles(string source, string target, HashSet<string> sourceFileSet, HashSet<string> targetFileSet)
        {
            // Files in both
            foreach (string path in sourceFileSet.Intersect(targetFileSet))
            {
                string sourcePath = source + '\\' + path;
                string targetPath = target + '\\' + path;
                FileInfo sourceFI = new FileInfo(sourcePath);
                FileInfo targetFI = new FileInfo(targetPath);
                long sourceLength = sourceFI.Length;
                long targetLength = targetFI.Length;
                string sourceTime = sourceFI.LastWriteTimeUtc.ToString();
                string targetTime = targetFI.LastWriteTimeUtc.ToString();

                UpdateLabel(sourcePath);

                if (sourceLength != targetLength || !sourceTime.Equals(targetTime))
                {
                    // Output log
                    string log = string.Format(StringValues.logUpdatedFileFormat, path, source, target);
                    AddToListBox(log);
                    File.Copy(sourcePath, targetPath, true);
                }
            }

            // New files
            foreach (string path in sourceFileSet.Except(targetFileSet))
            {
                string sourcePath = source + '\\' + path;
                string targetPath = target + '\\' + path;

                UpdateLabel(sourcePath);

                // Output log
                string log = string.Format(StringValues.logNewFileFormat, path, source, target);
                AddToListBox(log);
                File.Copy(sourcePath, targetPath);
            }
        }

        private void SyncFolders(string source, string target, HashSet<string> sourceDirSet, HashSet<string> targetDirSet, Queue<Pair> folderQueue)
        {
            // Dirs in both
            foreach (string path in sourceDirSet.Intersect(targetDirSet))
            {
                string sourcePath = source + '\\' + path;
                string targetPath = target + '\\' + path;

                folderQueue.Enqueue(new Pair(sourcePath, targetPath));
            }

            // New dir
            foreach (string path in sourceDirSet.Except(targetDirSet))
            {
                string sourcePath = source + '\\' + path;
                string targetPath = target + '\\' + path;

                string log = string.Format(StringValues.logNewFolderFormat, path, source, target);
                AddToListBox(log);
                Directory.CreateDirectory(targetPath);
                folderQueue.Enqueue(new Pair(sourcePath, targetPath));
            }
        }

        private void UpdateLabel(string s)
        {
            BeginInvoke(new Action(() =>
            {
                labelScanningPath.Text = s;
            }));
        }

        private void AddToListBox(string s)
        {
            BeginInvoke(new Action(() =>
            {
                listBox.Items.Add(s);
                listBox.TopIndex = listBox.Items.Count - 1;
            }));
        }

        private void SetButtons(bool value)
        {
            BeginInvoke(new Action(() =>
            {
                buttonBackA.Enabled = value;
                buttonBackB.Enabled = value;
                buttonGoUpA.Enabled = value;
                buttonGoUpB.Enabled = value;
                buttonRefreshA.Enabled = value;
                buttonRefreshB.Enabled = value;
                buttonOpenA.Enabled = value;
                buttonOpenB.Enabled = value;
                buttonAToB.Enabled = value;
                buttonBToA.Enabled = value;
            }));
        }

        private void SaveSettings()
        {
            Settings.Default.PathA = textBoxPathA.Text;
            Settings.Default.PathB = textBoxPathB.Text;
            Settings.Default.Save();
        }

        private void LoadSettings()
        {
            string pathA = Settings.Default.PathA;
            string pathB = Settings.Default.PathB;

            if (!Directory.Exists(pathA))
                pathA = StringValues.defaultPath;
            if (!Directory.Exists(pathB))
                pathB = StringValues.defaultPath;

            textBoxPathA.Text = pathA;
            textBoxPathB.Text = pathB;

            PaintListViewA(pathA);
            PaintListViewB(pathB);
            folderColA.Add(pathA);
            folderColB.Add(pathB);
        }

        private class Pair
        {
            public string source;
            public string target;

            public Pair(string source, string target)
            {
                this.source = source;
                this.target = target;
            }
        }
    }
}
