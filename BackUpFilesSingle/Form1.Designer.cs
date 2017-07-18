namespace BackUpFilesSingle
{
    partial class FormBackupAssistant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBackupAssistant));
            this.listViewA = new System.Windows.Forms.ListView();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.buttonBackA = new System.Windows.Forms.Button();
            this.groupBoxViewMode = new System.Windows.Forms.GroupBox();
            this.radioButtonTile = new System.Windows.Forms.RadioButton();
            this.radioButtonDetails = new System.Windows.Forms.RadioButton();
            this.radioButtonList = new System.Windows.Forms.RadioButton();
            this.radioButtonSmallIcon = new System.Windows.Forms.RadioButton();
            this.radioButtonLargeIcon = new System.Windows.Forms.RadioButton();
            this.buttonOpenA = new System.Windows.Forms.Button();
            this.labelFolderA = new System.Windows.Forms.Label();
            this.listViewB = new System.Windows.Forms.ListView();
            this.labelFolderB = new System.Windows.Forms.Label();
            this.buttonBackB = new System.Windows.Forms.Button();
            this.buttonOpenB = new System.Windows.Forms.Button();
            this.buttonAToB = new System.Windows.Forms.Button();
            this.listBox = new System.Windows.Forms.ListBox();
            this.buttonGoUpA = new System.Windows.Forms.Button();
            this.buttonGoUpB = new System.Windows.Forms.Button();
            this.buttonBToA = new System.Windows.Forms.Button();
            this.textBoxPathA = new System.Windows.Forms.TextBox();
            this.textBoxPathB = new System.Windows.Forms.TextBox();
            this.buttonRefreshA = new System.Windows.Forms.Button();
            this.buttonRefreshB = new System.Windows.Forms.Button();
            this.groupBoxDetail = new System.Windows.Forms.GroupBox();
            this.labelScanning = new System.Windows.Forms.Label();
            this.labelScanningPath = new System.Windows.Forms.Label();
            this.buttonAbort = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxViewMode.SuspendLayout();
            this.groupBoxDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewA
            // 
            this.listViewA.LargeImageList = this.imageListLarge;
            this.listViewA.Location = new System.Drawing.Point(12, 61);
            this.listViewA.Name = "listViewA";
            this.listViewA.Size = new System.Drawing.Size(444, 356);
            this.listViewA.SmallImageList = this.imageListSmall;
            this.listViewA.TabIndex = 0;
            this.listViewA.UseCompatibleStateImageBehavior = false;
            this.listViewA.View = System.Windows.Forms.View.Details;
            this.listViewA.ItemActivate += new System.EventHandler(this.ListViewA_ItemActivate);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "Folder32x32.ICO");
            this.imageListLarge.Images.SetKeyName(1, "Text 32x32.ICO");
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "Folder 16x16.ICO");
            this.imageListSmall.Images.SetKeyName(1, "Text 16x16.ICO");
            // 
            // buttonBackA
            // 
            this.buttonBackA.Location = new System.Drawing.Point(12, 32);
            this.buttonBackA.Name = "buttonBackA";
            this.buttonBackA.Size = new System.Drawing.Size(75, 23);
            this.buttonBackA.TabIndex = 1;
            this.buttonBackA.Text = "Back";
            this.buttonBackA.UseVisualStyleBackColor = true;
            this.buttonBackA.Click += new System.EventHandler(this.ButtonBackA_Click);
            // 
            // groupBoxViewMode
            // 
            this.groupBoxViewMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBoxViewMode.Controls.Add(this.radioButtonTile);
            this.groupBoxViewMode.Controls.Add(this.radioButtonDetails);
            this.groupBoxViewMode.Controls.Add(this.radioButtonList);
            this.groupBoxViewMode.Controls.Add(this.radioButtonSmallIcon);
            this.groupBoxViewMode.Controls.Add(this.radioButtonLargeIcon);
            this.groupBoxViewMode.Location = new System.Drawing.Point(462, 12);
            this.groupBoxViewMode.Name = "groupBoxViewMode";
            this.groupBoxViewMode.Size = new System.Drawing.Size(127, 147);
            this.groupBoxViewMode.TabIndex = 3;
            this.groupBoxViewMode.TabStop = false;
            this.groupBoxViewMode.Text = "View Mode";
            // 
            // radioButtonTile
            // 
            this.radioButtonTile.AutoSize = true;
            this.radioButtonTile.Location = new System.Drawing.Point(6, 111);
            this.radioButtonTile.Name = "radioButtonTile";
            this.radioButtonTile.Size = new System.Drawing.Size(42, 17);
            this.radioButtonTile.TabIndex = 0;
            this.radioButtonTile.Text = "Tile";
            this.radioButtonTile.UseVisualStyleBackColor = true;
            this.radioButtonTile.CheckedChanged += new System.EventHandler(this.RadioButtonTile_CheckedChanged);
            // 
            // radioButtonDetails
            // 
            this.radioButtonDetails.AutoSize = true;
            this.radioButtonDetails.Checked = true;
            this.radioButtonDetails.Location = new System.Drawing.Point(6, 88);
            this.radioButtonDetails.Name = "radioButtonDetails";
            this.radioButtonDetails.Size = new System.Drawing.Size(57, 17);
            this.radioButtonDetails.TabIndex = 0;
            this.radioButtonDetails.TabStop = true;
            this.radioButtonDetails.Text = "Details";
            this.radioButtonDetails.UseVisualStyleBackColor = true;
            this.radioButtonDetails.CheckedChanged += new System.EventHandler(this.RadioButtonDetails_CheckedChanged);
            // 
            // radioButtonList
            // 
            this.radioButtonList.AutoSize = true;
            this.radioButtonList.Location = new System.Drawing.Point(6, 65);
            this.radioButtonList.Name = "radioButtonList";
            this.radioButtonList.Size = new System.Drawing.Size(41, 17);
            this.radioButtonList.TabIndex = 0;
            this.radioButtonList.Text = "List";
            this.radioButtonList.UseVisualStyleBackColor = true;
            this.radioButtonList.CheckedChanged += new System.EventHandler(this.RadioButtonList_CheckedChanged);
            // 
            // radioButtonSmallIcon
            // 
            this.radioButtonSmallIcon.AutoSize = true;
            this.radioButtonSmallIcon.Location = new System.Drawing.Point(6, 42);
            this.radioButtonSmallIcon.Name = "radioButtonSmallIcon";
            this.radioButtonSmallIcon.Size = new System.Drawing.Size(74, 17);
            this.radioButtonSmallIcon.TabIndex = 0;
            this.radioButtonSmallIcon.Text = "Small Icon";
            this.radioButtonSmallIcon.UseVisualStyleBackColor = true;
            this.radioButtonSmallIcon.CheckedChanged += new System.EventHandler(this.RadioButtonSmallIcon_CheckedChanged);
            // 
            // radioButtonLargeIcon
            // 
            this.radioButtonLargeIcon.AutoSize = true;
            this.radioButtonLargeIcon.Location = new System.Drawing.Point(6, 19);
            this.radioButtonLargeIcon.Name = "radioButtonLargeIcon";
            this.radioButtonLargeIcon.Size = new System.Drawing.Size(76, 17);
            this.radioButtonLargeIcon.TabIndex = 0;
            this.radioButtonLargeIcon.Text = "Large Icon";
            this.radioButtonLargeIcon.UseVisualStyleBackColor = true;
            this.radioButtonLargeIcon.CheckedChanged += new System.EventHandler(this.RadioButtonLargeIcon_CheckedChanged);
            // 
            // buttonOpenA
            // 
            this.buttonOpenA.Location = new System.Drawing.Point(381, 32);
            this.buttonOpenA.Name = "buttonOpenA";
            this.buttonOpenA.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenA.TabIndex = 4;
            this.buttonOpenA.Text = "Open";
            this.buttonOpenA.UseVisualStyleBackColor = true;
            this.buttonOpenA.Click += new System.EventHandler(this.ButtonOpenA_Click);
            // 
            // labelFolderA
            // 
            this.labelFolderA.AutoSize = true;
            this.labelFolderA.Location = new System.Drawing.Point(13, 9);
            this.labelFolderA.Name = "labelFolderA";
            this.labelFolderA.Size = new System.Drawing.Size(49, 13);
            this.labelFolderA.TabIndex = 5;
            this.labelFolderA.Text = "Folder A:";
            // 
            // listViewB
            // 
            this.listViewB.LargeImageList = this.imageListLarge;
            this.listViewB.Location = new System.Drawing.Point(595, 61);
            this.listViewB.Name = "listViewB";
            this.listViewB.Size = new System.Drawing.Size(442, 356);
            this.listViewB.SmallImageList = this.imageListSmall;
            this.listViewB.TabIndex = 0;
            this.listViewB.UseCompatibleStateImageBehavior = false;
            this.listViewB.View = System.Windows.Forms.View.Details;
            this.listViewB.ItemActivate += new System.EventHandler(this.ListViewB_ItemActivate);
            // 
            // labelFolderB
            // 
            this.labelFolderB.AutoSize = true;
            this.labelFolderB.Location = new System.Drawing.Point(596, 9);
            this.labelFolderB.Name = "labelFolderB";
            this.labelFolderB.Size = new System.Drawing.Size(49, 13);
            this.labelFolderB.TabIndex = 5;
            this.labelFolderB.Text = "Folder B:";
            // 
            // buttonBackB
            // 
            this.buttonBackB.Location = new System.Drawing.Point(593, 32);
            this.buttonBackB.Name = "buttonBackB";
            this.buttonBackB.Size = new System.Drawing.Size(75, 23);
            this.buttonBackB.TabIndex = 1;
            this.buttonBackB.Text = "Back";
            this.buttonBackB.UseVisualStyleBackColor = true;
            this.buttonBackB.Click += new System.EventHandler(this.ButtonBackB_Click);
            // 
            // buttonOpenB
            // 
            this.buttonOpenB.Location = new System.Drawing.Point(962, 32);
            this.buttonOpenB.Name = "buttonOpenB";
            this.buttonOpenB.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenB.TabIndex = 4;
            this.buttonOpenB.Text = "Open";
            this.buttonOpenB.UseVisualStyleBackColor = true;
            this.buttonOpenB.Click += new System.EventHandler(this.ButtonOpenB_Click);
            // 
            // buttonAToB
            // 
            this.buttonAToB.Location = new System.Drawing.Point(462, 194);
            this.buttonAToB.Name = "buttonAToB";
            this.buttonAToB.Size = new System.Drawing.Size(127, 32);
            this.buttonAToB.TabIndex = 8;
            this.buttonAToB.Text = ">>";
            this.buttonAToB.UseVisualStyleBackColor = true;
            this.buttonAToB.Click += new System.EventHandler(this.ButtonAToB_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(6, 19);
            this.listBox.Name = "listBox";
            this.listBox.ScrollAlwaysVisible = true;
            this.listBox.Size = new System.Drawing.Size(1013, 199);
            this.listBox.TabIndex = 10;
            // 
            // buttonGoUpA
            // 
            this.buttonGoUpA.Location = new System.Drawing.Point(93, 32);
            this.buttonGoUpA.Name = "buttonGoUpA";
            this.buttonGoUpA.Size = new System.Drawing.Size(75, 23);
            this.buttonGoUpA.TabIndex = 12;
            this.buttonGoUpA.Text = "Go Up";
            this.buttonGoUpA.UseVisualStyleBackColor = true;
            this.buttonGoUpA.Click += new System.EventHandler(this.ButtonGoUpA_Click);
            // 
            // buttonGoUpB
            // 
            this.buttonGoUpB.Location = new System.Drawing.Point(674, 32);
            this.buttonGoUpB.Name = "buttonGoUpB";
            this.buttonGoUpB.Size = new System.Drawing.Size(75, 23);
            this.buttonGoUpB.TabIndex = 13;
            this.buttonGoUpB.Text = "Go Up";
            this.buttonGoUpB.UseVisualStyleBackColor = true;
            this.buttonGoUpB.Click += new System.EventHandler(this.ButtonGoUpB_Click);
            // 
            // buttonBToA
            // 
            this.buttonBToA.Location = new System.Drawing.Point(462, 258);
            this.buttonBToA.Name = "buttonBToA";
            this.buttonBToA.Size = new System.Drawing.Size(127, 32);
            this.buttonBToA.TabIndex = 14;
            this.buttonBToA.Text = "<<";
            this.buttonBToA.UseVisualStyleBackColor = true;
            this.buttonBToA.Click += new System.EventHandler(this.ButtonBToA_Click);
            // 
            // textBoxPathA
            // 
            this.textBoxPathA.Location = new System.Drawing.Point(93, 6);
            this.textBoxPathA.Name = "textBoxPathA";
            this.textBoxPathA.ReadOnly = true;
            this.textBoxPathA.Size = new System.Drawing.Size(363, 20);
            this.textBoxPathA.TabIndex = 15;
            // 
            // textBoxPathB
            // 
            this.textBoxPathB.Location = new System.Drawing.Point(674, 6);
            this.textBoxPathB.Name = "textBoxPathB";
            this.textBoxPathB.ReadOnly = true;
            this.textBoxPathB.Size = new System.Drawing.Size(363, 20);
            this.textBoxPathB.TabIndex = 16;
            // 
            // buttonRefreshA
            // 
            this.buttonRefreshA.Location = new System.Drawing.Point(174, 32);
            this.buttonRefreshA.Name = "buttonRefreshA";
            this.buttonRefreshA.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshA.TabIndex = 17;
            this.buttonRefreshA.Text = "Refresh";
            this.buttonRefreshA.UseVisualStyleBackColor = true;
            this.buttonRefreshA.Click += new System.EventHandler(this.ButtonRefreshA_Click);
            // 
            // buttonRefreshB
            // 
            this.buttonRefreshB.Location = new System.Drawing.Point(755, 32);
            this.buttonRefreshB.Name = "buttonRefreshB";
            this.buttonRefreshB.Size = new System.Drawing.Size(75, 23);
            this.buttonRefreshB.TabIndex = 18;
            this.buttonRefreshB.Text = "Refresh";
            this.buttonRefreshB.UseVisualStyleBackColor = true;
            this.buttonRefreshB.Click += new System.EventHandler(this.ButtonRefreshB_Click);
            // 
            // groupBoxDetail
            // 
            this.groupBoxDetail.Controls.Add(this.listBox);
            this.groupBoxDetail.Location = new System.Drawing.Point(12, 457);
            this.groupBoxDetail.Name = "groupBoxDetail";
            this.groupBoxDetail.Size = new System.Drawing.Size(1025, 230);
            this.groupBoxDetail.TabIndex = 1;
            this.groupBoxDetail.TabStop = false;
            this.groupBoxDetail.Text = "Detail";
            // 
            // labelScanning
            // 
            this.labelScanning.AutoSize = true;
            this.labelScanning.Location = new System.Drawing.Point(12, 441);
            this.labelScanning.Name = "labelScanning";
            this.labelScanning.Size = new System.Drawing.Size(55, 13);
            this.labelScanning.TabIndex = 19;
            this.labelScanning.Text = "Scanning:";
            // 
            // labelScanningPath
            // 
            this.labelScanningPath.Location = new System.Drawing.Point(73, 441);
            this.labelScanningPath.Name = "labelScanningPath";
            this.labelScanningPath.Size = new System.Drawing.Size(883, 13);
            this.labelScanningPath.TabIndex = 20;
            // 
            // buttonAbort
            // 
            this.buttonAbort.Location = new System.Drawing.Point(462, 322);
            this.buttonAbort.Name = "buttonAbort";
            this.buttonAbort.Size = new System.Drawing.Size(127, 64);
            this.buttonAbort.TabIndex = 21;
            this.buttonAbort.Text = "Abort";
            this.buttonAbort.UseVisualStyleBackColor = true;
            this.buttonAbort.Click += new System.EventHandler(this.ButtonAbort_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(962, 436);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 22;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // FormBackupAssistant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1049, 699);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonAbort);
            this.Controls.Add(this.labelScanningPath);
            this.Controls.Add(this.labelScanning);
            this.Controls.Add(this.groupBoxDetail);
            this.Controls.Add(this.buttonRefreshB);
            this.Controls.Add(this.buttonRefreshA);
            this.Controls.Add(this.textBoxPathB);
            this.Controls.Add(this.textBoxPathA);
            this.Controls.Add(this.buttonBToA);
            this.Controls.Add(this.buttonGoUpB);
            this.Controls.Add(this.buttonGoUpA);
            this.Controls.Add(this.buttonAToB);
            this.Controls.Add(this.labelFolderB);
            this.Controls.Add(this.labelFolderA);
            this.Controls.Add(this.buttonOpenB);
            this.Controls.Add(this.buttonOpenA);
            this.Controls.Add(this.groupBoxViewMode);
            this.Controls.Add(this.buttonBackB);
            this.Controls.Add(this.buttonBackA);
            this.Controls.Add(this.listViewB);
            this.Controls.Add(this.listViewA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormBackupAssistant";
            this.Text = "Backup Assistant";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxViewMode.ResumeLayout(false);
            this.groupBoxViewMode.PerformLayout();
            this.groupBoxDetail.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewA;
        private System.Windows.Forms.Button buttonBackA;
        private System.Windows.Forms.GroupBox groupBoxViewMode;
        private System.Windows.Forms.RadioButton radioButtonSmallIcon;
        private System.Windows.Forms.RadioButton radioButtonLargeIcon;
        private System.Windows.Forms.RadioButton radioButtonTile;
        private System.Windows.Forms.RadioButton radioButtonDetails;
        private System.Windows.Forms.RadioButton radioButtonList;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.Button buttonOpenA;
        private System.Windows.Forms.Label labelFolderA;
        private System.Windows.Forms.ListView listViewB;
        private System.Windows.Forms.Label labelFolderB;
        private System.Windows.Forms.Button buttonBackB;
        private System.Windows.Forms.Button buttonOpenB;
        private System.Windows.Forms.Button buttonAToB;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Button buttonGoUpA;
        private System.Windows.Forms.Button buttonGoUpB;
        private System.Windows.Forms.Button buttonBToA;
        private System.Windows.Forms.TextBox textBoxPathA;
        private System.Windows.Forms.TextBox textBoxPathB;
        private System.Windows.Forms.Button buttonRefreshA;
        private System.Windows.Forms.Button buttonRefreshB;
        private System.Windows.Forms.GroupBox groupBoxDetail;
        private System.Windows.Forms.Label labelScanning;
        private System.Windows.Forms.Label labelScanningPath;
        private System.Windows.Forms.Button buttonAbort;
        private System.Windows.Forms.Button buttonClear;
    }
}

