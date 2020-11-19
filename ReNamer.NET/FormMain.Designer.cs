namespace Files_Renamer.NET
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonRemoveSelected = new System.Windows.Forms.Button();
            this.checkPreview = new System.Windows.Forms.CheckBox();
            this.buttonRemoveAll = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonSource = new System.Windows.Forms.Button();
            this.textFilename = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioCopy = new System.Windows.Forms.RadioButton();
            this.radioMove = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.radioDisabled = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBefore = new System.Windows.Forms.RadioButton();
            this.radioAfter = new System.Windows.Forms.RadioButton();
            this.numericIndex = new System.Windows.Forms.NumericUpDown();
            this.textStart = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxResize = new System.Windows.Forms.CheckBox();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textResY = new System.Windows.Forms.TextBox();
            this.textResX = new System.Windows.Forms.TextBox();
            this.labelDestination = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.progressBarRanamer = new System.Windows.Forms.ProgressBar();
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.labelCounter = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonDestination = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.checkBoxHigh = new System.Windows.Forms.CheckBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkExtension = new System.Windows.Forms.CheckBox();
            this.textExtension = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkIncludeExt = new System.Windows.Forms.CheckBox();
            this.radioCaseNone = new System.Windows.Forms.RadioButton();
            this.radioCaseUpper = new System.Windows.Forms.RadioButton();
            this.radioCaseFirst = new System.Windows.Forms.RadioButton();
            this.radioCaseLower = new System.Windows.Forms.RadioButton();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.CheckFileExists = false;
            this.openFileDialog1.Multiselect = true;
            this.openFileDialog1.Title = "Select source files";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.buttonRemoveSelected);
            this.groupBox2.Controls.Add(this.checkPreview);
            this.groupBox2.Controls.Add(this.buttonRemoveAll);
            this.groupBox2.Controls.Add(this.labelTotal);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.buttonMoveUp);
            this.groupBox2.Controls.Add(this.buttonMoveDown);
            this.groupBox2.Controls.Add(this.dataGridViewFiles);
            this.groupBox2.Controls.Add(this.buttonSource);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 352);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Source :";
            // 
            // buttonRemoveSelected
            // 
            this.buttonRemoveSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveSelected.Enabled = false;
            this.buttonRemoveSelected.Location = new System.Drawing.Point(6, 280);
            this.buttonRemoveSelected.Name = "buttonRemoveSelected";
            this.buttonRemoveSelected.Size = new System.Drawing.Size(120, 27);
            this.buttonRemoveSelected.TabIndex = 24;
            this.buttonRemoveSelected.Text = "Remove";
            this.buttonRemoveSelected.UseVisualStyleBackColor = true;
            this.buttonRemoveSelected.Click += new System.EventHandler(this.buttonRemoveSelected_Click);
            // 
            // checkPreview
            // 
            this.checkPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkPreview.AutoSize = true;
            this.checkPreview.Checked = true;
            this.checkPreview.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkPreview.Location = new System.Drawing.Point(17, 191);
            this.checkPreview.Name = "checkPreview";
            this.checkPreview.Size = new System.Drawing.Size(95, 17);
            this.checkPreview.TabIndex = 23;
            this.checkPreview.Text = "Image preview";
            this.checkPreview.UseVisualStyleBackColor = true;
            this.checkPreview.CheckedChanged += new System.EventHandler(this.checkPreview_CheckedChanged);
            // 
            // buttonRemoveAll
            // 
            this.buttonRemoveAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonRemoveAll.Enabled = false;
            this.buttonRemoveAll.Location = new System.Drawing.Point(6, 313);
            this.buttonRemoveAll.Name = "buttonRemoveAll";
            this.buttonRemoveAll.Size = new System.Drawing.Size(120, 27);
            this.buttonRemoveAll.TabIndex = 13;
            this.buttonRemoveAll.Text = "Remove All";
            this.buttonRemoveAll.UseVisualStyleBackColor = true;
            this.buttonRemoveAll.Click += new System.EventHandler(this.buttonRemoveAll_Click);
            // 
            // labelTotal
            // 
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Location = new System.Drawing.Point(9, 83);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(117, 20);
            this.labelTotal.TabIndex = 12;
            this.labelTotal.Text = "0";
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Current files :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMoveUp.Enabled = false;
            this.buttonMoveUp.Location = new System.Drawing.Point(6, 214);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(120, 27);
            this.buttonMoveUp.TabIndex = 9;
            this.buttonMoveUp.Text = "Move Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMoveDown.Enabled = false;
            this.buttonMoveDown.Location = new System.Drawing.Point(6, 247);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(120, 27);
            this.buttonMoveDown.TabIndex = 8;
            this.buttonMoveDown.Text = "Move Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AllowDrop = true;
            this.dataGridViewFiles.AllowUserToAddRows = false;
            this.dataGridViewFiles.AllowUserToOrderColumns = true;
            this.dataGridViewFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewFiles.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column4,
            this.Column3});
            this.dataGridViewFiles.Location = new System.Drawing.Point(132, 19);
            this.dataGridViewFiles.MultiSelect = false;
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.RowHeadersVisible = false;
            this.dataGridViewFiles.RowTemplate.Height = 50;
            this.dataGridViewFiles.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFiles.Size = new System.Drawing.Size(645, 323);
            this.dataGridViewFiles.TabIndex = 5;
            this.dataGridViewFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFiles_CellDoubleClick);
            this.dataGridViewFiles.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridViewFiles_RowsAdded);
            this.dataGridViewFiles.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewFiles_RowsRemoved);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 95.5414F;
            this.Column1.HeaderText = "Directory";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.FillWeight = 175.3167F;
            this.Column2.HeaderText = "Filename";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "New Filename";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 250;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Ext";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column3
            // 
            this.Column3.Description = "Image Preview";
            this.Column3.FillWeight = 29.14186F;
            this.Column3.HeaderText = "Image";
            this.Column3.Image = ((System.Drawing.Image)(resources.GetObject("Column3.Image")));
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 61;
            // 
            // buttonSource
            // 
            this.buttonSource.Location = new System.Drawing.Point(6, 19);
            this.buttonSource.Name = "buttonSource";
            this.buttonSource.Size = new System.Drawing.Size(120, 27);
            this.buttonSource.TabIndex = 4;
            this.buttonSource.Text = "Select files...";
            this.buttonSource.UseVisualStyleBackColor = true;
            this.buttonSource.Click += new System.EventHandler(this.buttonSource_Click);
            // 
            // textFilename
            // 
            this.textFilename.Location = new System.Drawing.Point(196, 5);
            this.textFilename.Name = "textFilename";
            this.textFilename.Size = new System.Drawing.Size(191, 20);
            this.textFilename.TabIndex = 17;
            this.textFilename.Text = "filename";
            this.textFilename.TextChanged += new System.EventHandler(this.textMatrix_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioCopy);
            this.panel3.Controls.Add(this.radioMove);
            this.panel3.Location = new System.Drawing.Point(9, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 45);
            this.panel3.TabIndex = 39;
            // 
            // radioCopy
            // 
            this.radioCopy.AutoSize = true;
            this.radioCopy.Checked = true;
            this.radioCopy.Location = new System.Drawing.Point(3, 3);
            this.radioCopy.Name = "radioCopy";
            this.radioCopy.Size = new System.Drawing.Size(49, 17);
            this.radioCopy.TabIndex = 36;
            this.radioCopy.TabStop = true;
            this.radioCopy.Text = "Copy";
            this.toolTipInfo.SetToolTip(this.radioCopy, "Copy source files to destination directory and preserve the source");
            this.radioCopy.UseVisualStyleBackColor = true;
            // 
            // radioMove
            // 
            this.radioMove.AutoSize = true;
            this.radioMove.Location = new System.Drawing.Point(3, 25);
            this.radioMove.Name = "radioMove";
            this.radioMove.Size = new System.Drawing.Size(52, 17);
            this.radioMove.TabIndex = 35;
            this.radioMove.Text = "Move";
            this.toolTipInfo.SetToolTip(this.radioMove, "Move source files to destination directory");
            this.radioMove.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.radioDisabled);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioBefore);
            this.panel1.Controls.Add(this.radioAfter);
            this.panel1.Controls.Add(this.numericIndex);
            this.panel1.Controls.Add(this.textStart);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textFilename);
            this.panel1.Location = new System.Drawing.Point(64, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 78);
            this.panel1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Matrix : ";
            // 
            // radioDisabled
            // 
            this.radioDisabled.AutoSize = true;
            this.radioDisabled.Location = new System.Drawing.Point(3, 3);
            this.radioDisabled.Name = "radioDisabled";
            this.radioDisabled.Size = new System.Drawing.Size(66, 17);
            this.radioDisabled.TabIndex = 13;
            this.radioDisabled.Text = "Disabled";
            this.radioDisabled.UseVisualStyleBackColor = true;
            this.radioDisabled.CheckedChanged += new System.EventHandler(this.radioDisabled_CheckedChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(105, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Total index :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // radioBefore
            // 
            this.radioBefore.AutoSize = true;
            this.radioBefore.Location = new System.Drawing.Point(3, 23);
            this.radioBefore.Name = "radioBefore";
            this.radioBefore.Size = new System.Drawing.Size(56, 17);
            this.radioBefore.TabIndex = 11;
            this.radioBefore.Text = "Before";
            this.radioBefore.UseVisualStyleBackColor = true;
            this.radioBefore.CheckedChanged += new System.EventHandler(this.radioBefore_CheckedChanged);
            // 
            // radioAfter
            // 
            this.radioAfter.AutoSize = true;
            this.radioAfter.Checked = true;
            this.radioAfter.Location = new System.Drawing.Point(3, 46);
            this.radioAfter.Name = "radioAfter";
            this.radioAfter.Size = new System.Drawing.Size(47, 17);
            this.radioAfter.TabIndex = 12;
            this.radioAfter.TabStop = true;
            this.radioAfter.Text = "After";
            this.radioAfter.UseVisualStyleBackColor = true;
            this.radioAfter.CheckedChanged += new System.EventHandler(this.radioAfter_CheckedChanged);
            // 
            // numericIndex
            // 
            this.numericIndex.Location = new System.Drawing.Point(196, 29);
            this.numericIndex.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericIndex.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericIndex.Name = "numericIndex";
            this.numericIndex.Size = new System.Drawing.Size(67, 20);
            this.numericIndex.TabIndex = 9;
            this.numericIndex.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericIndex.ValueChanged += new System.EventHandler(this.numericIndex_ValueChanged);
            // 
            // textStart
            // 
            this.textStart.Location = new System.Drawing.Point(196, 55);
            this.textStart.MaxLength = 9;
            this.textStart.Name = "textStart";
            this.textStart.Size = new System.Drawing.Size(67, 20);
            this.textStart.TabIndex = 10;
            this.textStart.Text = "0";
            this.textStart.TextChanged += new System.EventHandler(this.textStart_TextChanged);
            this.textStart.Leave += new System.EventHandler(this.textStart_Leave);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(105, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Start number :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxResize
            // 
            this.checkBoxResize.AutoSize = true;
            this.checkBoxResize.Location = new System.Drawing.Point(12, 22);
            this.checkBoxResize.Name = "checkBoxResize";
            this.checkBoxResize.Size = new System.Drawing.Size(112, 17);
            this.checkBoxResize.TabIndex = 33;
            this.checkBoxResize.Text = "To fixed resolution";
            this.toolTipInfo.SetToolTip(this.checkBoxResize, "If source file is image, resize its resolution to specified value");
            this.checkBoxResize.UseVisualStyleBackColor = true;
            this.checkBoxResize.CheckedChanged += new System.EventHandler(this.checkBoxResize_CheckedChanged);
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(89, 23);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(141, 17);
            this.checkBoxOverwrite.TabIndex = 31;
            this.checkBoxOverwrite.Text = "Overwrite destination file";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            this.checkBoxOverwrite.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkBoxOverwrite_MouseClick);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(191, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 20);
            this.label7.TabIndex = 27;
            this.label7.Text = "X";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textResY
            // 
            this.textResY.Enabled = false;
            this.textResY.Location = new System.Drawing.Point(211, 19);
            this.textResY.Name = "textResY";
            this.textResY.Size = new System.Drawing.Size(54, 20);
            this.textResY.TabIndex = 26;
            this.textResY.Text = "768";
            // 
            // textResX
            // 
            this.textResX.Enabled = false;
            this.textResX.Location = new System.Drawing.Point(132, 19);
            this.textResX.Name = "textResX";
            this.textResX.Size = new System.Drawing.Size(54, 20);
            this.textResX.TabIndex = 24;
            this.textResX.Text = "1024";
            // 
            // labelDestination
            // 
            this.labelDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDestination.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDestination.Location = new System.Drawing.Point(132, 20);
            this.labelDestination.Name = "labelDestination";
            this.labelDestination.Size = new System.Drawing.Size(645, 27);
            this.labelDestination.TabIndex = 22;
            this.labelDestination.Text = "[ Select a directory ]";
            this.labelDestination.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select destination directory";
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.Location = new System.Drawing.Point(680, 679);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(117, 27);
            this.buttonExit.TabIndex = 8;
            this.buttonExit.Text = "Exit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAbout
            // 
            this.buttonAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAbout.Location = new System.Drawing.Point(680, 646);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(117, 27);
            this.buttonAbout.TabIndex = 9;
            this.buttonAbout.Text = "About...";
            this.buttonAbout.UseVisualStyleBackColor = true;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(680, 612);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(117, 27);
            this.buttonStart.TabIndex = 10;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // progressBarRanamer
            // 
            this.progressBarRanamer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBarRanamer.Location = new System.Drawing.Point(110, 712);
            this.progressBarRanamer.Name = "progressBarRanamer";
            this.progressBarRanamer.Size = new System.Drawing.Size(687, 23);
            this.progressBarRanamer.TabIndex = 10;
            // 
            // labelCounter
            // 
            this.labelCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCounter.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCounter.Location = new System.Drawing.Point(12, 712);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(92, 23);
            this.labelCounter.TabIndex = 11;
            this.labelCounter.Text = " 0 / 0";
            this.labelCounter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonDestination);
            this.groupBox1.Controls.Add(this.labelDestination);
            this.groupBox1.Location = new System.Drawing.Point(12, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 59);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Destination : ";
            // 
            // buttonDestination
            // 
            this.buttonDestination.Location = new System.Drawing.Point(9, 20);
            this.buttonDestination.Name = "buttonDestination";
            this.buttonDestination.Size = new System.Drawing.Size(117, 27);
            this.buttonDestination.TabIndex = 23;
            this.buttonDestination.Text = "Select Directory...";
            this.buttonDestination.UseVisualStyleBackColor = true;
            this.buttonDestination.Click += new System.EventHandler(this.buttonDestination_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox5.Controls.Add(this.panel3);
            this.groupBox5.Controls.Add(this.checkBoxOverwrite);
            this.groupBox5.Location = new System.Drawing.Point(476, 521);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(321, 78);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operations : ";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox6.Controls.Add(this.checkBoxHigh);
            this.groupBox6.Controls.Add(this.textResX);
            this.groupBox6.Controls.Add(this.textResY);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.checkBoxResize);
            this.groupBox6.Location = new System.Drawing.Point(476, 439);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(321, 76);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Resize Images : ";
            // 
            // checkBoxHigh
            // 
            this.checkBoxHigh.AutoSize = true;
            this.checkBoxHigh.Checked = true;
            this.checkBoxHigh.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHigh.Enabled = false;
            this.checkBoxHigh.Location = new System.Drawing.Point(12, 45);
            this.checkBoxHigh.Name = "checkBoxHigh";
            this.checkBoxHigh.Size = new System.Drawing.Size(124, 17);
            this.checkBoxHigh.TabIndex = 41;
            this.checkBoxHigh.Text = "Force high resolution";
            this.checkBoxHigh.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox7.Controls.Add(this.label5);
            this.groupBox7.Controls.Add(this.checkExtension);
            this.groupBox7.Controls.Add(this.textExtension);
            this.groupBox7.Controls.Add(this.panel1);
            this.groupBox7.Controls.Add(this.label2);
            this.groupBox7.Controls.Add(this.panel4);
            this.groupBox7.Location = new System.Drawing.Point(12, 439);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(460, 264);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "New Filename : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Counter : ";
            // 
            // checkExtension
            // 
            this.checkExtension.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkExtension.Location = new System.Drawing.Point(9, 108);
            this.checkExtension.Name = "checkExtension";
            this.checkExtension.Size = new System.Drawing.Size(104, 30);
            this.checkExtension.TabIndex = 20;
            this.checkExtension.Text = "New Extension :";
            this.checkExtension.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkExtension.UseVisualStyleBackColor = true;
            this.checkExtension.Click += new System.EventHandler(this.checkExtension_Click);
            this.checkExtension.CheckedChanged += new System.EventHandler(this.checkExtension_CheckedChanged);
            // 
            // textExtension
            // 
            this.textExtension.Enabled = false;
            this.textExtension.Location = new System.Drawing.Point(117, 113);
            this.textExtension.Name = "textExtension";
            this.textExtension.Size = new System.Drawing.Size(61, 20);
            this.textExtension.TabIndex = 19;
            this.textExtension.Text = "ext";
            this.textExtension.TextChanged += new System.EventHandler(this.textExtension_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Case : ";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.checkIncludeExt);
            this.panel4.Controls.Add(this.radioCaseNone);
            this.panel4.Controls.Add(this.radioCaseUpper);
            this.panel4.Controls.Add(this.radioCaseFirst);
            this.panel4.Controls.Add(this.radioCaseLower);
            this.panel4.Location = new System.Drawing.Point(64, 146);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(304, 89);
            this.panel4.TabIndex = 3;
            // 
            // checkIncludeExt
            // 
            this.checkIncludeExt.AutoSize = true;
            this.checkIncludeExt.Checked = true;
            this.checkIncludeExt.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkIncludeExt.Enabled = false;
            this.checkIncludeExt.Location = new System.Drawing.Point(132, 5);
            this.checkIncludeExt.Name = "checkIncludeExt";
            this.checkIncludeExt.Size = new System.Drawing.Size(109, 17);
            this.checkIncludeExt.TabIndex = 21;
            this.checkIncludeExt.Text = "Include extension";
            this.checkIncludeExt.UseVisualStyleBackColor = true;
            this.checkIncludeExt.CheckedChanged += new System.EventHandler(this.checkIncludeExt_CheckedChanged);
            // 
            // radioCaseNone
            // 
            this.radioCaseNone.AutoSize = true;
            this.radioCaseNone.Checked = true;
            this.radioCaseNone.Location = new System.Drawing.Point(3, 4);
            this.radioCaseNone.Name = "radioCaseNone";
            this.radioCaseNone.Size = new System.Drawing.Size(51, 17);
            this.radioCaseNone.TabIndex = 3;
            this.radioCaseNone.TabStop = true;
            this.radioCaseNone.Text = "None";
            this.radioCaseNone.UseVisualStyleBackColor = true;
            this.radioCaseNone.CheckedChanged += new System.EventHandler(this.radioCaseNone_CheckedChanged);
            // 
            // radioCaseUpper
            // 
            this.radioCaseUpper.AutoSize = true;
            this.radioCaseUpper.Location = new System.Drawing.Point(3, 26);
            this.radioCaseUpper.Name = "radioCaseUpper";
            this.radioCaseUpper.Size = new System.Drawing.Size(90, 17);
            this.radioCaseUpper.TabIndex = 0;
            this.radioCaseUpper.Text = "UPPERCASE";
            this.radioCaseUpper.UseVisualStyleBackColor = true;
            this.radioCaseUpper.CheckedChanged += new System.EventHandler(this.radioCaseUpper_CheckedChanged);
            // 
            // radioCaseFirst
            // 
            this.radioCaseFirst.AutoSize = true;
            this.radioCaseFirst.Location = new System.Drawing.Point(3, 66);
            this.radioCaseFirst.Name = "radioCaseFirst";
            this.radioCaseFirst.Size = new System.Drawing.Size(85, 17);
            this.radioCaseFirst.TabIndex = 2;
            this.radioCaseFirst.Text = "First letter up";
            this.radioCaseFirst.UseVisualStyleBackColor = true;
            this.radioCaseFirst.CheckedChanged += new System.EventHandler(this.radioCaseFirst_CheckedChanged);
            // 
            // radioCaseLower
            // 
            this.radioCaseLower.AutoSize = true;
            this.radioCaseLower.Location = new System.Drawing.Point(3, 46);
            this.radioCaseLower.Name = "radioCaseLower";
            this.radioCaseLower.Size = new System.Drawing.Size(73, 17);
            this.radioCaseLower.TabIndex = 1;
            this.radioCaseLower.Text = "lowercase";
            this.radioCaseLower.UseVisualStyleBackColor = true;
            this.radioCaseLower.CheckedChanged += new System.EventHandler(this.radioCaseLower_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 746);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.progressBarRanamer);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonAbout);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.groupBox2);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReNamer.NET";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericIndex)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.Button buttonSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textStart;
        private System.Windows.Forms.NumericUpDown numericIndex;
        private System.Windows.Forms.TextBox textFilename;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioAfter;
        private System.Windows.Forms.RadioButton radioBefore;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRemoveAll;
        private System.Windows.Forms.Label labelDestination;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textResY;
        private System.Windows.Forms.TextBox textResX;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.CheckBox checkBoxResize;
        private System.Windows.Forms.ProgressBar progressBarRanamer;
        private System.Windows.Forms.CheckBox checkPreview;
        private System.Windows.Forms.RadioButton radioCopy;
        private System.Windows.Forms.RadioButton radioMove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.Button buttonRemoveSelected;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelCounter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonDestination;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox checkBoxHigh;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioDisabled;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton radioCaseUpper;
        private System.Windows.Forms.RadioButton radioCaseFirst;
        private System.Windows.Forms.RadioButton radioCaseLower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkExtension;
        private System.Windows.Forms.TextBox textExtension;
        private System.Windows.Forms.RadioButton radioCaseNone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkIncludeExt;
        private System.Windows.Forms.Label label6;
    }
}

