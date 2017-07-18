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
    public partial class Form1 : Form
    {
        private System.Collections.Specialized.StringCollection folderColA;
        private System.Collections.Specialized.StringCollection folderColB;
        private bool finished;
        private Thread thread;

        public Form1()
        {
            InitializeComponent();

            finished = true;
            folderColA = new System.Collections.Specialized.StringCollection();
            folderColB = new System.Collections.Specialized.StringCollection();

            CreateHeaderAndFillListView();
            PaintListViewA(@"C:\");
            PaintListViewB(@"C:\");
            folderColA.Add(@"C:\");
            folderColB.Add(@"C:\");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!finished)
            {
                MessageBox.Show("Please wait until the sync finished or abort it.", "Warning", MessageBoxButtons.OK);
                e.Cancel = true;
            }
        }

        private void CreateHeaderAndFillListView()
        {
            ColumnHeader colHead;

            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            colHead.Width = 120;
            listViewA.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            colHead.Width = 120;
            listViewB.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            colHead.Width = 120;
            listViewA.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = "Size";
            colHead.Width = 120;
            listViewB.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            colHead.Width = 120;
            listViewA.Columns.Add(colHead); // Insert the header

            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
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

        private void radioButtonLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.LargeIcon;
                this.listViewB.View = View.LargeIcon;
            }
        }

        private void radioButtonSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.SmallIcon;
                this.listViewB.View = View.SmallIcon;
            }
        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.List;
                this.listViewB.View = View.List;
            }
        }

        private void radioButtonDetails_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.Details;
                this.listViewB.View = View.Details;
            }
        }

        private void radioButtonTile_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = (RadioButton)sender;
            if (rdb.Checked)
            {
                this.listViewA.View = View.Tile;
                this.listViewB.View = View.Tile;
            }
        }

        private void listViewA_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex == 0)
            {
                PaintListViewA(filename);
                folderColA.Add(filename);
            }
        }

        private void listViewB_ItemActivate(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView lw = (System.Windows.Forms.ListView)sender;
            string filename = lw.SelectedItems[0].Tag.ToString();
            if (lw.SelectedItems[0].ImageIndex == 0)
            {
                PaintListViewB(filename);
                folderColB.Add(filename);
            }
        }

        private void buttonOpenA_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select a folder." })
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

        private void buttonOpenB_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description = "Select a folder." })
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

        private void buttonBackA_Click(object sender, EventArgs e)
        {
            if (folderColA.Count > 1)
            {
                PaintListViewA(folderColA[folderColA.Count - 2].ToString());
                folderColA.RemoveAt(folderColA.Count - 1);
            }
            else
                PaintListViewA(folderColA[0].ToString());
        }

        private void buttonBackB_Click(object sender, EventArgs e)
        {
            if (folderColB.Count > 1)
            {
                PaintListViewB(folderColB[folderColB.Count - 2].ToString());
                folderColB.RemoveAt(folderColB.Count - 1);
            }
            else
                PaintListViewB(folderColB[0].ToString());
        }

        private void buttonGoUpA_Click(object sender, EventArgs e)
        {
            if (folderColA.Count == 1)
                return;

            string path = textBoxPathA.Text;
            string[] s = path.Split('\\');

            if (s.Length == 1)
                return;

            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);
            for (int i = 1; i < s.Length - 1; i++)
                sb.Append('\\').Append(s[i]);

            PaintListViewA(sb.ToString());
            folderColA.Add(sb.ToString());
        }

        private void buttonGoUpB_Click(object sender, EventArgs e)
        {
            if (folderColB.Count == 1)
                return;

            string path = textBoxPathB.Text;
            string[] s = path.Split('\\');

            if (s.Length == 1)
                return;

            StringBuilder sb = new StringBuilder();
            sb.Append(s[0]);
            for (int i = 1; i < s.Length - 1; i++)
                sb.Append('\\').Append(s[i]);

            PaintListViewB(sb.ToString());
            folderColB.Add(sb.ToString());
        }

        private void buttonRefreshA_Click(object sender, EventArgs e)
        {
            refreshA();
        }

        private void buttonRefreshB_Click(object sender, EventArgs e)
        {
            refreshB();
        }

        private void buttonAToB_Click(object sender, EventArgs e)
        {
            string source = folderColA[folderColA.Count - 1];
            string target = folderColB[folderColB.Count - 1];
            beforeStart(source, target);
        }

        private void buttonBToA_Click(object sender, EventArgs e)
        {
            string source = folderColB[folderColB.Count - 1];
            string target = folderColA[folderColA.Count - 1];
            beforeStart(source, target);
        }

        private void buttonAbort_Click(object sender, EventArgs e)
        {
            if (finished)
                return;

            thread.Abort();

            addToListBox("Aborted.");
            updateLabel("");
            setButtons(true);
            finished = true;

            refreshA();
            refreshB();
        }

        private void refreshA()
        {
            BeginInvoke(new Action(() =>
            {
                PaintListViewA(textBoxPathA.Text);
            }));            
        }

        private void refreshB()
        {
            BeginInvoke(new Action(() =>
            {
                PaintListViewB(textBoxPathB.Text);
            }));
        }

        private void beforeStart(string source, string target)
        {
            string title = "PLEASE CONFIRM!";
            string body = "Files will be synced from\n"
                        + source
                        + "\nto\n"
                        + target
                        + "\nChoose Yes to proceed.";

            DialogResult result = MessageBox.Show(body, title, MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
            {
                return;
            }

            setButtons(false);
            finished = false;
            addToListBox("Begin Synchronization.");
            
            ParameterizedThreadStart pts = new ParameterizedThreadStart(startSync);
            thread = new Thread(pts);
            Pair pair = new Pair(source, target);
            thread.Start(pair);
        }

        private void startSync(object o)
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
                makeSets(source, out sourceFileSet, out sourceDirSet);
                makeSets(target, out targetFileSet, out targetDirSet);

                syncFiles(source, target, sourceFileSet, targetFileSet);

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

                    string log = string.Format("[New Folder] - {0}: {1} -> {2}", path, source, target);
                    addToListBox(log);
                    Directory.CreateDirectory(targetPath);
                    folderQueue.Enqueue(new Pair(sourcePath, targetPath));
                }
            }

            addToListBox("Finished.");
            updateLabel("");
            setButtons(true);
            finished = true;

            refreshA();
            refreshB();
        }

        private void makeSets(string path, out HashSet<string> fileSet, out HashSet<string> dirSet)
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

        private void syncFiles(string source, string target, HashSet<string> sourceFileSet, HashSet<string> targetFileSet)
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

                updateLabel(sourcePath);

                if (sourceLength != targetLength || !sourceTime.Equals(targetTime))
                {
                    // Output log
                    string log = string.Format("[Updated File] - {0}: {1} -> {2}", path, source, target);
                    addToListBox(log);
                    File.Copy(sourcePath, targetPath, true);
                }
            }

            // New files
            foreach (string path in sourceFileSet.Except(targetFileSet))
            {
                string sourcePath = source + '\\' + path;
                string targetPath = target + '\\' + path;

                updateLabel(sourcePath);

                // Output log
                string log = string.Format("[New File] - {0}: {1} -> {2}", path, source, target);
                addToListBox(log);
                File.Copy(sourcePath, targetPath);
            }
        }

        private void copyFiles(string sourcePath, string targetPath)
        {
            string[] fileList = Directory.GetFiles(sourcePath);

            foreach (string file in fileList)
            {
                string[] ss = file.Split('\\');
                string fileName = ss[ss.Length - 1];

                updateLabel(sourcePath + '\\' + fileName);

                string log = string.Format("[New File] - {0}: {1} -> {2}", fileName, sourcePath, targetPath);
                addToListBox(log);
                File.Copy(file, targetPath + '\\' + fileName);
            }
        }

        private void updateLabel(string s)
        {
            BeginInvoke(new Action(() =>
            {
                labelScanningPath.Text = s;
            }));
        }

        private void addToListBox(string s)
        {
            BeginInvoke(new Action(() =>
            {
                listBox.Items.Add(s);
                listBox.TopIndex = listBox.Items.Count - 1;
            }));
        }

        private void setButtons(bool value)
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
