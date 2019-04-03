namespace Composers_Database
{
    partial class DatabaseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseForm));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.sONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibraryDataSet = new Composers_Database.DBLibraryDataSet();
            this.pERFORMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pERFORMANCEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPOSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PRF_SONG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SONG = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.sONGTableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.SONGTableAdapter();
            this.pERFORMERTableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.PERFORMERTableAdapter();
            this.pERFORMANCETableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.PERFORMANCETableAdapter();
            this.cOMPOSERTableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.COMPOSERTableAdapter();
            this.queriesTableAdapter1 = new Composers_Database.DBLibraryDataSetTableAdapters.QueriesTableAdapter();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            this.SongsSearch = new System.Windows.Forms.Button();
            this.SongsDelete = new System.Windows.Forms.Button();
            this.SongsUpdate = new System.Windows.Forms.Button();
            this.SongsDataGridView = new System.Windows.Forms.DataGridView();
            this.sNGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGGENREDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGCMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGDURATIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGPPSIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PerformersSearch = new System.Windows.Forms.Button();
            this.PerformersDelete = new System.Windows.Forms.Button();
            this.PerformersSave = new System.Windows.Forms.Button();
            this.PerformersDataGridView = new System.Windows.Forms.DataGridView();
            this.pFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNATIONALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.PerformancesSearch = new System.Windows.Forms.Button();
            this.PerformancesDelete = new System.Windows.Forms.Button();
            this.PerformancesSave = new System.Windows.Forms.Button();
            this.PerformancesDataGridView = new System.Windows.Forms.DataGridView();
            this.pRFPERFORMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRFSONGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.pRFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.ComposersSave = new System.Windows.Forms.Button();
            this.ComposersDataGridView = new System.Windows.Forms.DataGridView();
            this.cMPFULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPNATIONALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPBIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ComposersSearch = new System.Windows.Forms.Button();
            this.ComposersDelete = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataGridView)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformersDataGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PerformancesDataGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComposersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Location = new System.Drawing.Point(0, 31);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(799, 566);
            this.tabControl.TabIndex = 0;
            // 
            // sONGBindingSource
            // 
            this.sONGBindingSource.DataMember = "SONG";
            this.sONGBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // dBLibraryDataSet
            // 
            this.dBLibraryDataSet.DataSetName = "DBLibraryDataSet";
            this.dBLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERFORMERBindingSource
            // 
            this.pERFORMERBindingSource.DataMember = "PERFORMER";
            this.pERFORMERBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // pERFORMANCEBindingSource
            // 
            this.pERFORMANCEBindingSource.DataMember = "PERFORMANCE";
            this.pERFORMANCEBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // cOMPOSERBindingSource
            // 
            this.cOMPOSERBindingSource.DataMember = "COMPOSER";
            this.cOMPOSERBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(799, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // PRF_SONG
            // 
            this.PRF_SONG.HeaderText = "Song";
            this.PRF_SONG.Name = "PRF_SONG";
            this.PRF_SONG.Width = 187;
            // 
            // SONG
            // 
            this.SONG.DataPropertyName = "PRF_ID";
            this.SONG.HeaderText = "Song";
            this.SONG.Name = "SONG";
            this.SONG.Width = 187;
            // 
            // sONGTableAdapter
            // 
            this.sONGTableAdapter.ClearBeforeFill = true;
            // 
            // pERFORMERTableAdapter
            // 
            this.pERFORMERTableAdapter.ClearBeforeFill = true;
            // 
            // pERFORMANCETableAdapter
            // 
            this.pERFORMANCETableAdapter.ClearBeforeFill = true;
            // 
            // cOMPOSERTableAdapter
            // 
            this.cOMPOSERTableAdapter.ClearBeforeFill = true;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.LightGray;
            this.tabPage1.BackgroundImage = global::Composers_Database.Properties.Resources.glowing_music_notes_moving_on_sheet_passionate_love_song_romantic_background_scwo4cuge_thumbnail_full01;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.ButtonUpdate);
            this.tabPage1.Controls.Add(this.SongsSearch);
            this.tabPage1.Controls.Add(this.SongsDelete);
            this.tabPage1.Controls.Add(this.SongsUpdate);
            this.tabPage1.Controls.Add(this.SongsDataGridView);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 537);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Songs";
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonUpdate.Location = new System.Drawing.Point(600, 23);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(168, 47);
            this.ButtonUpdate.TabIndex = 2;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // SongsSearch
            // 
            this.SongsSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SongsSearch.Location = new System.Drawing.Point(400, 23);
            this.SongsSearch.Name = "SongsSearch";
            this.SongsSearch.Size = new System.Drawing.Size(168, 47);
            this.SongsSearch.TabIndex = 3;
            this.SongsSearch.Text = "Add";
            this.SongsSearch.UseVisualStyleBackColor = true;
            this.SongsSearch.Click += new System.EventHandler(this.buttonSongsSearch_Click);
            // 
            // SongsDelete
            // 
            this.SongsDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SongsDelete.Location = new System.Drawing.Point(204, 24);
            this.SongsDelete.Name = "SongsDelete";
            this.SongsDelete.Size = new System.Drawing.Size(168, 48);
            this.SongsDelete.TabIndex = 2;
            this.SongsDelete.Text = "Delete";
            this.SongsDelete.UseVisualStyleBackColor = true;
            this.SongsDelete.Click += new System.EventHandler(this.buttonSongsDelete_Click);
            // 
            // SongsUpdate
            // 
            this.SongsUpdate.Location = new System.Drawing.Point(7, 23);
            this.SongsUpdate.Name = "SongsUpdate";
            this.SongsUpdate.Size = new System.Drawing.Size(168, 48);
            this.SongsUpdate.TabIndex = 1;
            this.SongsUpdate.Text = "Save";
            this.SongsUpdate.UseVisualStyleBackColor = true;
            this.SongsUpdate.Click += new System.EventHandler(this.buttonSongsSave_Click);
            // 
            // SongsDataGridView
            // 
            this.SongsDataGridView.AllowUserToDeleteRows = false;
            this.SongsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SongsDataGridView.AutoGenerateColumns = false;
            this.SongsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SongsDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.SongsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SongsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNGIDDataGridViewTextBoxColumn,
            this.sNGNAMEDataGridViewTextBoxColumn,
            this.sNGGENREDataGridViewTextBoxColumn,
            this.sNGCMPIDDataGridViewTextBoxColumn,
            this.sNGDURATIONDataGridViewTextBoxColumn,
            this.sNGPPSIDDataGridViewTextBoxColumn});
            this.SongsDataGridView.DataSource = this.sONGBindingSource;
            this.SongsDataGridView.Location = new System.Drawing.Point(-1, 96);
            this.SongsDataGridView.Name = "SongsDataGridView";
            this.SongsDataGridView.RowTemplate.Height = 24;
            this.SongsDataGridView.Size = new System.Drawing.Size(791, 50);
            this.SongsDataGridView.TabIndex = 0;
            this.SongsDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.SongsDataGridView_DataError);
            this.SongsDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.SongsDataGridView_RowsAdded);
            this.SongsDataGridView.Resize += new System.EventHandler(this.SongsDataGridView_Resize);
            // 
            // sNGIDDataGridViewTextBoxColumn
            // 
            this.sNGIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.HeaderText = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.Name = "sNGIDDataGridViewTextBoxColumn";
            this.sNGIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sNGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNGNAMEDataGridViewTextBoxColumn
            // 
            this.sNGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNG_NAME";
            this.sNGNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.sNGNAMEDataGridViewTextBoxColumn.Name = "sNGNAMEDataGridViewTextBoxColumn";
            this.sNGNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNGNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNGGENREDataGridViewTextBoxColumn
            // 
            this.sNGGENREDataGridViewTextBoxColumn.DataPropertyName = "SNG_GENRE";
            this.sNGGENREDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.sNGGENREDataGridViewTextBoxColumn.Name = "sNGGENREDataGridViewTextBoxColumn";
            this.sNGGENREDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNGGENREDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNGCMPIDDataGridViewTextBoxColumn
            // 
            this.sNGCMPIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_CMP_ID";
            this.sNGCMPIDDataGridViewTextBoxColumn.HeaderText = "Composer";
            this.sNGCMPIDDataGridViewTextBoxColumn.Name = "sNGCMPIDDataGridViewTextBoxColumn";
            this.sNGCMPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNGCMPIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.sNGCMPIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sNGCMPIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNGDURATIONDataGridViewTextBoxColumn
            // 
            this.sNGDURATIONDataGridViewTextBoxColumn.DataPropertyName = "SNG_DURATION";
            this.sNGDURATIONDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.sNGDURATIONDataGridViewTextBoxColumn.Name = "sNGDURATIONDataGridViewTextBoxColumn";
            this.sNGDURATIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNGDURATIONDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // sNGPPSIDDataGridViewTextBoxColumn
            // 
            this.sNGPPSIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_PPS_ID";
            this.sNGPPSIDDataGridViewTextBoxColumn.HeaderText = "SNG_PPS_ID";
            this.sNGPPSIDDataGridViewTextBoxColumn.Name = "sNGPPSIDDataGridViewTextBoxColumn";
            this.sNGPPSIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.sNGPPSIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.LightGray;
            this.tabPage2.BackgroundImage = global::Composers_Database.Properties.Resources.glowing_music_notes_moving_on_sheet_passionate_love_song_romantic_background_scwo4cuge_thumbnail_full01;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage2.Controls.Add(this.PerformersSearch);
            this.tabPage2.Controls.Add(this.PerformersDelete);
            this.tabPage2.Controls.Add(this.PerformersSave);
            this.tabPage2.Controls.Add(this.PerformersDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(791, 537);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Performers";
            // 
            // PerformersSearch
            // 
            this.PerformersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformersSearch.Location = new System.Drawing.Point(584, 24);
            this.PerformersSearch.Name = "PerformersSearch";
            this.PerformersSearch.Size = new System.Drawing.Size(168, 47);
            this.PerformersSearch.TabIndex = 3;
            this.PerformersSearch.Text = "Search";
            this.PerformersSearch.UseVisualStyleBackColor = true;
            this.PerformersSearch.Click += new System.EventHandler(this.buttonPerformersSearch_Click);
            // 
            // PerformersDelete
            // 
            this.PerformersDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PerformersDelete.Location = new System.Drawing.Point(312, 23);
            this.PerformersDelete.Name = "PerformersDelete";
            this.PerformersDelete.Size = new System.Drawing.Size(168, 48);
            this.PerformersDelete.TabIndex = 2;
            this.PerformersDelete.Text = "Delete";
            this.PerformersDelete.UseVisualStyleBackColor = true;
            this.PerformersDelete.Click += new System.EventHandler(this.buttonPerformersDelete_Click);
            // 
            // PerformersSave
            // 
            this.PerformersSave.Location = new System.Drawing.Point(31, 23);
            this.PerformersSave.Name = "PerformersSave";
            this.PerformersSave.Size = new System.Drawing.Size(168, 48);
            this.PerformersSave.TabIndex = 1;
            this.PerformersSave.Text = "Save";
            this.PerformersSave.UseVisualStyleBackColor = true;
            this.PerformersSave.Click += new System.EventHandler(this.buttonPerformersSave_Click);
            // 
            // PerformersDataGridView
            // 
            this.PerformersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformersDataGridView.AutoGenerateColumns = false;
            this.PerformersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PerformersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pFNAMEDataGridViewTextBoxColumn,
            this.pFIDDataGridViewTextBoxColumn,
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn,
            this.pFNATIONALITYDataGridViewTextBoxColumn});
            this.PerformersDataGridView.DataSource = this.pERFORMERBindingSource;
            this.PerformersDataGridView.Location = new System.Drawing.Point(-1, 96);
            this.PerformersDataGridView.Name = "PerformersDataGridView";
            this.PerformersDataGridView.RowTemplate.Height = 24;
            this.PerformersDataGridView.Size = new System.Drawing.Size(791, 50);
            this.PerformersDataGridView.TabIndex = 0;
            this.PerformersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PerformersDataGridView_CellClick);
            this.PerformersDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.PerformersDataGridView_DataError);
            this.PerformersDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PerformersDataGridView_RowsAdded);
            this.PerformersDataGridView.Resize += new System.EventHandler(this.PerfomersDataGridView_Resize);
            // 
            // pFNAMEDataGridViewTextBoxColumn
            // 
            this.pFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PF_NAME";
            this.pFNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pFNAMEDataGridViewTextBoxColumn.Name = "pFNAMEDataGridViewTextBoxColumn";
            this.pFNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pFIDDataGridViewTextBoxColumn
            // 
            this.pFIDDataGridViewTextBoxColumn.DataPropertyName = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.HeaderText = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.Name = "pFIDDataGridViewTextBoxColumn";
            this.pFIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pFDATEOFBIRTHDataGridViewTextBoxColumn
            // 
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.DataPropertyName = "PF_DATE_OF_BIRTH";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.Name = "pFDATEOFBIRTHDataGridViewTextBoxColumn";
            this.pFDATEOFBIRTHDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pFNATIONALITYDataGridViewTextBoxColumn
            // 
            this.pFNATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "PF_NATIONALITY";
            this.pFNATIONALITYDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.pFNATIONALITYDataGridViewTextBoxColumn.Name = "pFNATIONALITYDataGridViewTextBoxColumn";
            this.pFNATIONALITYDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.BackgroundImage = global::Composers_Database.Properties.Resources.photo_2018_11_26_18_18_16;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.PerformancesSearch);
            this.tabPage3.Controls.Add(this.PerformancesDelete);
            this.tabPage3.Controls.Add(this.PerformancesSave);
            this.tabPage3.Controls.Add(this.PerformancesDataGridView);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(791, 537);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Performances";
            // 
            // PerformancesSearch
            // 
            this.PerformancesSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformancesSearch.Location = new System.Drawing.Point(584, 24);
            this.PerformancesSearch.Name = "PerformancesSearch";
            this.PerformancesSearch.Size = new System.Drawing.Size(168, 47);
            this.PerformancesSearch.TabIndex = 3;
            this.PerformancesSearch.Text = "Search";
            this.PerformancesSearch.UseVisualStyleBackColor = true;
            this.PerformancesSearch.Click += new System.EventHandler(this.buttonPerformancesSearch_Click);
            // 
            // PerformancesDelete
            // 
            this.PerformancesDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PerformancesDelete.Location = new System.Drawing.Point(312, 23);
            this.PerformancesDelete.Name = "PerformancesDelete";
            this.PerformancesDelete.Size = new System.Drawing.Size(168, 48);
            this.PerformancesDelete.TabIndex = 2;
            this.PerformancesDelete.Text = "Delete";
            this.PerformancesDelete.UseVisualStyleBackColor = true;
            this.PerformancesDelete.Click += new System.EventHandler(this.buttonPerformancesDelete_Click);
            // 
            // PerformancesSave
            // 
            this.PerformancesSave.Location = new System.Drawing.Point(31, 23);
            this.PerformancesSave.Name = "PerformancesSave";
            this.PerformancesSave.Size = new System.Drawing.Size(168, 48);
            this.PerformancesSave.TabIndex = 1;
            this.PerformancesSave.Text = "Save";
            this.PerformancesSave.UseVisualStyleBackColor = true;
            this.PerformancesSave.Click += new System.EventHandler(this.buttonPerformancesSave_Click);
            // 
            // PerformancesDataGridView
            // 
            this.PerformancesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PerformancesDataGridView.AutoGenerateColumns = false;
            this.PerformancesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PerformancesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PerformancesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PerformancesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRFPERFORMERIDDataGridViewTextBoxColumn,
            this.pRFSONGIDDataGridViewTextBoxColumn,
            this.pRFDATEDataGridViewTextBoxColumn,
            this.pRFIDDataGridViewTextBoxColumn,
            this.pRFNAMEDataGridViewTextBoxColumn,
            this.pRFPLACEDataGridViewTextBoxColumn});
            this.PerformancesDataGridView.DataSource = this.pERFORMANCEBindingSource;
            this.PerformancesDataGridView.Location = new System.Drawing.Point(-1, 96);
            this.PerformancesDataGridView.Name = "PerformancesDataGridView";
            this.PerformancesDataGridView.RowTemplate.Height = 24;
            this.PerformancesDataGridView.Size = new System.Drawing.Size(791, 50);
            this.PerformancesDataGridView.TabIndex = 0;
            this.PerformancesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PerformancesDataGridView_CellClick);
            this.PerformancesDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.PerformancesDataGridView_DataError);
            this.PerformancesDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.PerformancesDataGridView_RowsAdded);
            this.PerformancesDataGridView.Resize += new System.EventHandler(this.PerformancesDataGridView_Resize);
            // 
            // pRFPERFORMERIDDataGridViewTextBoxColumn
            // 
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_PERFORMER_ID";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DataSource = this.pERFORMERBindingSource;
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DisplayMember = "PF_NAME";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.HeaderText = "Performer";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Name = "pRFPERFORMERIDDataGridViewTextBoxColumn";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.ValueMember = "PF_ID";
            // 
            // pRFSONGIDDataGridViewTextBoxColumn
            // 
            this.pRFSONGIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_SONG_ID";
            this.pRFSONGIDDataGridViewTextBoxColumn.DataSource = this.sONGBindingSource;
            this.pRFSONGIDDataGridViewTextBoxColumn.DisplayMember = "SNG_NAME";
            this.pRFSONGIDDataGridViewTextBoxColumn.HeaderText = "Song";
            this.pRFSONGIDDataGridViewTextBoxColumn.Name = "pRFSONGIDDataGridViewTextBoxColumn";
            this.pRFSONGIDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.pRFSONGIDDataGridViewTextBoxColumn.ValueMember = "SNG_ID";
            // 
            // pRFDATEDataGridViewTextBoxColumn
            // 
            this.pRFDATEDataGridViewTextBoxColumn.DataPropertyName = "PRF_DATE";
            this.pRFDATEDataGridViewTextBoxColumn.HeaderText = "Date";
            this.pRFDATEDataGridViewTextBoxColumn.Name = "pRFDATEDataGridViewTextBoxColumn";
            this.pRFDATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pRFIDDataGridViewTextBoxColumn
            // 
            this.pRFIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.HeaderText = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.Name = "pRFIDDataGridViewTextBoxColumn";
            this.pRFIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pRFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFNAMEDataGridViewTextBoxColumn
            // 
            this.pRFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRF_NAME";
            this.pRFNAMEDataGridViewTextBoxColumn.HeaderText = "Name";
            this.pRFNAMEDataGridViewTextBoxColumn.Name = "pRFNAMEDataGridViewTextBoxColumn";
            this.pRFNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // pRFPLACEDataGridViewTextBoxColumn
            // 
            this.pRFPLACEDataGridViewTextBoxColumn.DataPropertyName = "PRF_PLACE";
            this.pRFPLACEDataGridViewTextBoxColumn.HeaderText = "Place";
            this.pRFPLACEDataGridViewTextBoxColumn.Name = "pRFPLACEDataGridViewTextBoxColumn";
            this.pRFPLACEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.LightGray;
            this.tabPage4.BackgroundImage = global::Composers_Database.Properties.Resources.A_95537_1399383484_6429_jpeg;
            this.tabPage4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage4.Controls.Add(this.ComposersSave);
            this.tabPage4.Controls.Add(this.ComposersDataGridView);
            this.tabPage4.Controls.Add(this.ComposersSearch);
            this.tabPage4.Controls.Add(this.ComposersDelete);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(791, 537);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Composers";
            // 
            // ComposersSave
            // 
            this.ComposersSave.Location = new System.Drawing.Point(31, 23);
            this.ComposersSave.Name = "ComposersSave";
            this.ComposersSave.Size = new System.Drawing.Size(168, 48);
            this.ComposersSave.TabIndex = 4;
            this.ComposersSave.Text = "Save";
            this.ComposersSave.UseVisualStyleBackColor = true;
            // 
            // ComposersDataGridView
            // 
            this.ComposersDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComposersDataGridView.AutoGenerateColumns = false;
            this.ComposersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ComposersDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.ComposersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ComposersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cMPFULLNAMEDataGridViewTextBoxColumn,
            this.cMPIDDataGridViewTextBoxColumn,
            this.cMPNATIONALITYDataGridViewTextBoxColumn,
            this.cMPBIRTHDATEDataGridViewTextBoxColumn});
            this.ComposersDataGridView.DataSource = this.cOMPOSERBindingSource;
            this.ComposersDataGridView.Location = new System.Drawing.Point(-1, 96);
            this.ComposersDataGridView.Name = "ComposersDataGridView";
            this.ComposersDataGridView.RowTemplate.Height = 24;
            this.ComposersDataGridView.Size = new System.Drawing.Size(791, 50);
            this.ComposersDataGridView.TabIndex = 3;
            this.ComposersDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ComposersDataGridView_CellClick);
            this.ComposersDataGridView.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.ComposersDataGridView_DataError);
            this.ComposersDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ComposersDataGridView_RowsAdded);
            this.ComposersDataGridView.Resize += new System.EventHandler(this.ComposersDataGridView_Resize);
            // 
            // cMPFULLNAMEDataGridViewTextBoxColumn
            // 
            this.cMPFULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CMP_FULL_NAME";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.HeaderText = "Full Name";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.Name = "cMPFULLNAMEDataGridViewTextBoxColumn";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cMPIDDataGridViewTextBoxColumn
            // 
            this.cMPIDDataGridViewTextBoxColumn.DataPropertyName = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.HeaderText = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.Name = "cMPIDDataGridViewTextBoxColumn";
            this.cMPIDDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.cMPIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMPNATIONALITYDataGridViewTextBoxColumn
            // 
            this.cMPNATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "CMP_NATIONALITY";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.HeaderText = "Nationality";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.Name = "cMPNATIONALITYDataGridViewTextBoxColumn";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // cMPBIRTHDATEDataGridViewTextBoxColumn
            // 
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "CMP_BIRTH_DATE";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.Name = "cMPBIRTHDATEDataGridViewTextBoxColumn";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ComposersSearch
            // 
            this.ComposersSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ComposersSearch.Location = new System.Drawing.Point(584, 24);
            this.ComposersSearch.Name = "ComposersSearch";
            this.ComposersSearch.Size = new System.Drawing.Size(168, 47);
            this.ComposersSearch.TabIndex = 2;
            this.ComposersSearch.Text = "Search";
            this.ComposersSearch.UseVisualStyleBackColor = true;
            this.ComposersSearch.Click += new System.EventHandler(this.buttonComposersSearch_Click);
            // 
            // ComposersDelete
            // 
            this.ComposersDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ComposersDelete.Location = new System.Drawing.Point(312, 23);
            this.ComposersDelete.Name = "ComposersDelete";
            this.ComposersDelete.Size = new System.Drawing.Size(168, 48);
            this.ComposersDelete.TabIndex = 1;
            this.ComposersDelete.Text = "Delete";
            this.ComposersDelete.UseVisualStyleBackColor = true;
            this.ComposersDelete.Click += new System.EventHandler(this.buttonComposersDelete_Click);
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(799, 601);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DatabaseForm";
            this.Text = "Composers Database";
            this.Activated += new System.EventHandler(this.DatabaseForm_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SongsDataGridView)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerformersDataGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PerformancesDataGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ComposersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button SongsSearch;
        private System.Windows.Forms.Button SongsDelete;
        private System.Windows.Forms.Button SongsUpdate;
        private System.Windows.Forms.DataGridView SongsDataGridView;
        private System.Windows.Forms.Button PerformersSearch;
        private System.Windows.Forms.Button PerformersDelete;
        private System.Windows.Forms.Button PerformersSave;
        private System.Windows.Forms.DataGridView PerformersDataGridView;
        private System.Windows.Forms.DataGridView PerformancesDataGridView;
        private System.Windows.Forms.Button PerformancesSearch;
        private System.Windows.Forms.Button PerformancesDelete;
        private System.Windows.Forms.Button PerformancesSave;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button ComposersSearch;
        private System.Windows.Forms.Button ComposersDelete;
        private System.Windows.Forms.DataGridView ComposersDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button ComposersSave;
        private System.Windows.Forms.DataGridViewComboBoxColumn PRF_SONG;
        private System.Windows.Forms.DataGridViewComboBoxColumn SONG;
        private DBLibraryDataSet dBLibraryDataSet;
        private System.Windows.Forms.BindingSource sONGBindingSource;
        private DBLibraryDataSetTableAdapters.SONGTableAdapter sONGTableAdapter;
        private System.Windows.Forms.BindingSource pERFORMERBindingSource;
        private DBLibraryDataSetTableAdapters.PERFORMERTableAdapter pERFORMERTableAdapter;
        private System.Windows.Forms.BindingSource pERFORMANCEBindingSource;
        private DBLibraryDataSetTableAdapters.PERFORMANCETableAdapter pERFORMANCETableAdapter;
        private System.Windows.Forms.BindingSource cOMPOSERBindingSource;
        private DBLibraryDataSetTableAdapters.COMPOSERTableAdapter cOMPOSERTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFDATEOFBIRTHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNATIONALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pRFPERFORMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn pRFSONGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPNATIONALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPBIRTHDATEDataGridViewTextBoxColumn;
        private DBLibraryDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGGENREDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGCMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGDURATIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGPPSIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button ButtonUpdate;
    }
}

