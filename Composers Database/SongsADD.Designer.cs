namespace Composers_Database
{
    partial class SongsADD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongsADD));
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ButtonADD = new System.Windows.Forms.Button();
            this.queriesTableAdapter1 = new Composers_Database.DBLibraryDataSetTableAdapters.QueriesTableAdapter();
            this.songTableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.SONGTableAdapter();
            this.dbLibraryDataSet = new Composers_Database.DBLibraryDataSet();
            this.CompositorTextBox = new System.Windows.Forms.TextBox();
            this.ComposerComboBox = new System.Windows.Forms.ComboBox();
            this.cOMPOSERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cOMPOSERTableAdapter = new Composers_Database.DBLibraryDataSetTableAdapters.COMPOSERTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(199, 60);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(204, 30);
            this.NameTextBox.TabIndex = 0;
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenreTextBox.Location = new System.Drawing.Point(199, 108);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(204, 30);
            this.GenreTextBox.TabIndex = 1;
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationTextBox.Location = new System.Drawing.Point(199, 158);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(204, 30);
            this.DurationTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Duration:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(598, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration must be in format: XX:XX:XX (hours, minutes, seconds) !!!";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Compositor ID";
            // 
            // ButtonADD
            // 
            this.ButtonADD.Location = new System.Drawing.Point(516, 86);
            this.ButtonADD.Name = "ButtonADD";
            this.ButtonADD.Size = new System.Drawing.Size(150, 49);
            this.ButtonADD.TabIndex = 9;
            this.ButtonADD.Text = "Add";
            this.ButtonADD.UseVisualStyleBackColor = true;
            this.ButtonADD.Click += new System.EventHandler(this.ButtonADD_Click);
            // 
            // songTableAdapter
            // 
            this.songTableAdapter.ClearBeforeFill = true;
            // 
            // dbLibraryDataSet
            // 
            this.dbLibraryDataSet.DataSetName = "DBLibraryDataSet";
            this.dbLibraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CompositorTextBox
            // 
            this.CompositorTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompositorTextBox.Location = new System.Drawing.Point(199, 12);
            this.CompositorTextBox.Name = "CompositorTextBox";
            this.CompositorTextBox.Size = new System.Drawing.Size(204, 30);
            this.CompositorTextBox.TabIndex = 7;
            // 
            // ComposerComboBox
            // 
            this.ComposerComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComposerComboBox.FormattingEnabled = true;
            this.ComposerComboBox.Location = new System.Drawing.Point(449, 9);
            this.ComposerComboBox.Name = "ComposerComboBox";
            this.ComposerComboBox.Size = new System.Drawing.Size(217, 33);
            this.ComposerComboBox.TabIndex = 10;
            // 
            // cOMPOSERBindingSource
            // 
            this.cOMPOSERBindingSource.DataMember = "COMPOSER";
            this.cOMPOSERBindingSource.DataSource = this.dbLibraryDataSet;
            // 
            // cOMPOSERTableAdapter
            // 
            this.cOMPOSERTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.cOMPOSERBindingSource;
            this.comboBox1.DisplayMember = "CMP_FULL_NAME";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(488, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 11;
            // 
            // SongsADD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 318);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.ComposerComboBox);
            this.Controls.Add(this.ButtonADD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CompositorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DurationTextBox);
            this.Controls.Add(this.GenreTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SongsADD";
            this.Text = "SongsADD";
            this.Load += new System.EventHandler(this.SongsADD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbLibraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOMPOSERBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ButtonADD;
        private DBLibraryDataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
        private DBLibraryDataSetTableAdapters.SONGTableAdapter songTableAdapter;
        private DBLibraryDataSet dbLibraryDataSet;
        private System.Windows.Forms.TextBox CompositorTextBox;
        private System.Windows.Forms.ComboBox ComposerComboBox;
        private System.Windows.Forms.BindingSource cOMPOSERBindingSource;
        private DBLibraryDataSetTableAdapters.COMPOSERTableAdapter cOMPOSERTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}