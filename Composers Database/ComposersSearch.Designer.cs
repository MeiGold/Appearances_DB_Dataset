namespace Composers_Database
{
    partial class ComposersSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComposersSearch));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cMPIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPFULLNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPNATIONALITYDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cMPBIRTHDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sNGNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cOMPOSERSearchBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBLibraryDataSet = new Composers_Database.DBLibraryDataSet();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NationalityTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cOMPOSERSearchTableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.COMPOSERSearchTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERSearchBindingSource)).BeginInit();
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
            this.cMPIDDataGridViewTextBoxColumn,
            this.cMPFULLNAMEDataGridViewTextBoxColumn,
            this.cMPNATIONALITYDataGridViewTextBoxColumn,
            this.cMPBIRTHDATEDataGridViewTextBoxColumn,
            this.sNGIDDataGridViewTextBoxColumn,
            this.sNGNAMEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cOMPOSERSearchBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(799, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // cMPIDDataGridViewTextBoxColumn
            // 
            this.cMPIDDataGridViewTextBoxColumn.DataPropertyName = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.HeaderText = "CMP_ID";
            this.cMPIDDataGridViewTextBoxColumn.Name = "cMPIDDataGridViewTextBoxColumn";
            this.cMPIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.cMPIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cMPFULLNAMEDataGridViewTextBoxColumn
            // 
            this.cMPFULLNAMEDataGridViewTextBoxColumn.DataPropertyName = "CMP_FULL_NAME";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.HeaderText = "Composer Name";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.Name = "cMPFULLNAMEDataGridViewTextBoxColumn";
            this.cMPFULLNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cMPNATIONALITYDataGridViewTextBoxColumn
            // 
            this.cMPNATIONALITYDataGridViewTextBoxColumn.DataPropertyName = "CMP_NATIONALITY";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.HeaderText = "Composer Nationality";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.Name = "cMPNATIONALITYDataGridViewTextBoxColumn";
            this.cMPNATIONALITYDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cMPBIRTHDATEDataGridViewTextBoxColumn
            // 
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.DataPropertyName = "CMP_BIRTH_DATE";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.HeaderText = "Composer Birth Date";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.Name = "cMPBIRTHDATEDataGridViewTextBoxColumn";
            this.cMPBIRTHDATEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sNGIDDataGridViewTextBoxColumn
            // 
            this.sNGIDDataGridViewTextBoxColumn.DataPropertyName = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.HeaderText = "SNG_ID";
            this.sNGIDDataGridViewTextBoxColumn.Name = "sNGIDDataGridViewTextBoxColumn";
            this.sNGIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.sNGIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // sNGNAMEDataGridViewTextBoxColumn
            // 
            this.sNGNAMEDataGridViewTextBoxColumn.DataPropertyName = "SNG_NAME";
            this.sNGNAMEDataGridViewTextBoxColumn.HeaderText = "Song Name";
            this.sNGNAMEDataGridViewTextBoxColumn.Name = "sNGNAMEDataGridViewTextBoxColumn";
            this.sNGNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cOMPOSERSearchBindingSource
            // 
            this.cOMPOSERSearchBindingSource.DataMember = "COMPOSERSearch";
            this.cOMPOSERSearchBindingSource.DataSource = this.dBLibraryDataSet;
            // 
            // dBLibraryDataSet
            // 
            this.dBLibraryDataSet.DataSetName = "DBLibraryDataSet";
            this.dBLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(221, 13);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 1;
            // 
            // NationalityTextBox
            // 
            this.NationalityTextBox.Location = new System.Drawing.Point(221, 60);
            this.NationalityTextBox.Name = "NationalityTextBox";
            this.NationalityTextBox.Size = new System.Drawing.Size(100, 22);
            this.NationalityTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(410, 25);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(128, 43);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nationality:";
            // 
            // cOMPOSERSearchTableAdapter
            // 
            this.cOMPOSERSearchTableAdapter.ClearBeforeFill = true;
            // 
            // ComposersSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.NationalityTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ComposersSearch";
            this.Text = "ComposersSearch";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERSearchBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBLibraryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource cOMPOSERSearchBindingSource;
        private DBLibraryDataSet dBLibraryDataSet;
        private DBLibraryDataSetTableAdapters.COMPOSERSearchTableAdapter cOMPOSERSearchTableAdapter;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NationalityTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPFULLNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPNATIONALITYDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cMPBIRTHDATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNGNAMEDataGridViewTextBoxColumn;
    }
}