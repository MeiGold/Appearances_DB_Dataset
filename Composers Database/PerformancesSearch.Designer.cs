namespace Composers_Database
{
    partial class PerformancesSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerformancesSearch));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFPERFORMERIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFSONGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pRFPLACEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pFNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pERFORMANCESearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibraryDataSet = new Composers_Database.DBLibraryDataSet();
            this.pERFORMANCESearchTableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.PERFORMANCESearchTableAdapter();
            this.DateFrom = new System.Windows.Forms.DateTimePicker();
            this.DateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCESearchBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pRFIDDataGridViewTextBoxColumn,
            this.pRFPERFORMERIDDataGridViewTextBoxColumn,
            this.pRFSONGIDDataGridViewTextBoxColumn,
            this.pRFNAMEDataGridViewTextBoxColumn,
            this.pRFDATEDataGridViewTextBoxColumn,
            this.pRFPLACEDataGridViewTextBoxColumn,
            this.pFIDDataGridViewTextBoxColumn,
            this.pFNAMEDataGridViewTextBoxColumn,
            this.sNGIDDataGridViewTextBoxColumn,
            this.sNGNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pERFORMANCESearchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 337);
            this.dataGridView1.TabIndex = 0;
            // 
            // pRFIDDataGridViewTextBoxColumn
            // 
            this.pRFIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.HeaderText = "PRF_ID";
            this.pRFIDDataGridViewTextBoxColumn.Name = "pRFIDDataGridViewTextBoxColumn";
            this.pRFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFPERFORMERIDDataGridViewTextBoxColumn
            // 
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_PERFORMER_ID";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.HeaderText = "PRF_PERFORMER_ID";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Name = "pRFPERFORMERIDDataGridViewTextBoxColumn";
            this.pRFPERFORMERIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFSONGIDDataGridViewTextBoxColumn
            // 
            this.pRFSONGIDDataGridViewTextBoxColumn.DataPropertyName = "PRF_SONG_ID";
            this.pRFSONGIDDataGridViewTextBoxColumn.HeaderText = "PRF_SONG_ID";
            this.pRFSONGIDDataGridViewTextBoxColumn.Name = "pRFSONGIDDataGridViewTextBoxColumn";
            this.pRFSONGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pRFNAMEDataGridViewTextBoxColumn
            // 
            this.pRFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PRF_NAME";
            this.pRFNAMEDataGridViewTextBoxColumn.HeaderText = "Performance Name";
            this.pRFNAMEDataGridViewTextBoxColumn.Name = "pRFNAMEDataGridViewTextBoxColumn";
            // 
            // pRFDATEDataGridViewTextBoxColumn
            // 
            this.pRFDATEDataGridViewTextBoxColumn.DataPropertyName = "PRF_DATE";
            this.pRFDATEDataGridViewTextBoxColumn.HeaderText = "Performance Date";
            this.pRFDATEDataGridViewTextBoxColumn.Name = "pRFDATEDataGridViewTextBoxColumn";
            // 
            // pRFPLACEDataGridViewTextBoxColumn
            // 
            this.pRFPLACEDataGridViewTextBoxColumn.DataPropertyName = "PRF_PLACE";
            this.pRFPLACEDataGridViewTextBoxColumn.HeaderText = "Performance Place";
            this.pRFPLACEDataGridViewTextBoxColumn.Name = "pRFPLACEDataGridViewTextBoxColumn";
            // 
            // pFIDDataGridViewTextBoxColumn
            // 
            this.pFIDDataGridViewTextBoxColumn.DataPropertyName = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.HeaderText = "PF_ID";
            this.pFIDDataGridViewTextBoxColumn.Name = "pFIDDataGridViewTextBoxColumn";
            this.pFIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // pFNAMEDataGridViewTextBoxColumn
            // 
            this.pFNAMEDataGridViewTextBoxColumn.DataPropertyName = "PF_NAME";
            this.pFNAMEDataGridViewTextBoxColumn.HeaderText = "Performer";
            this.pFNAMEDataGridViewTextBoxColumn.Name = "pFNAMEDataGridViewTextBoxColumn";
            // 
            // sNGIDDataGridViewTextBoxColumn
            // 
            this.sNGIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.HeaderText = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.Name = "sNGIDDataGridViewTextBoxColumn";
            this.sNGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNGNAMEDataGridViewTextBoxColumn
            // 
            this.sNGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNG_NAME";
            this.sNGNAMEDataGridViewTextBoxColumn.HeaderText = "Song Name";
            this.sNGNAMEDataGridViewTextBoxColumn.Name = "sNGNAMEDataGridViewTextBoxColumn";
            // 
            // pERFORMANCESearchBindingSource
            // 
            this.pERFORMANCESearchBindingSource.DataMember = "PERFORMANCESearch";
            this.pERFORMANCESearchBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // dBLibraryDataSet
            // 
            this.dBLibraryDataSet.DataSetName = "DBLibraryDataSet";
            this.dBLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pERFORMANCESearchTableAdapter
            // 
            this.pERFORMANCESearchTableAdapter.ClearBeforeFill = true;
            // 
            // DateFrom
            // 
            this.DateFrom.Location = new System.Drawing.Point(121, 12);
            this.DateFrom.Name = "DateFrom";
            this.DateFrom.Size = new System.Drawing.Size(200, 22);
            this.DateFrom.TabIndex = 1;
            // 
            // DateTo
            // 
            this.DateTo.Location = new System.Drawing.Point(504, 12);
            this.DateTo.Name = "DateTo";
            this.DateTo.Size = new System.Drawing.Size(200, 22);
            this.DateTo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "To";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(294, 60);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(167, 31);
            this.SearchButton.TabIndex = 5;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // PerformancesSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DateTo);
            this.Controls.Add(this.DateFrom);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PerformancesSearch";
            this.Text = "PerformancesSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pERFORMANCESearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource pERFORMANCESearchBindingSource;
        private DBLibraryDataSet dBLibraryDataSet;
        private DBLibraryDataSetTableAdapters.PERFORMANCESearchTableAdapter pERFORMANCESearchTableAdapter;
        private System.Windows.Forms.DateTimePicker DateFrom;
        private System.Windows.Forms.DateTimePicker DateTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFPERFORMERIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFSONGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pRFPLACEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pFNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGNAMEDataGridViewTextBoxColumn;
    }
}