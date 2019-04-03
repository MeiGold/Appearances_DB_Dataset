using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Entity;
using Composers_Database.DBLibraryDataSetTableAdapters;

namespace Composers_Database
{

    public partial class DatabaseForm : System.Windows.Forms.Form
    {
        private DateTimePicker date;
        Image backgroundimage;
        public DatabaseForm()
        {
            InitializeComponent();
            sONGTableAdapter.Fill(dBLibraryDataSet.SONG);
            pERFORMERTableAdapter.Fill(dBLibraryDataSet.PERFORMER);
            pERFORMANCETableAdapter.Fill(dBLibraryDataSet.PERFORMANCE);
            cOMPOSERTableAdapter.Fill(dBLibraryDataSet.COMPOSER);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBLibraryDataSet.COMPOSER' table. You can move, or remove it, as needed.
            this.cOMPOSERTableAdapter.Fill(this.dBLibraryDataSet.COMPOSER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMANCE' table. You can move, or remove it, as needed.
            this.pERFORMANCETableAdapter.Fill(this.dBLibraryDataSet.PERFORMANCE);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMER' table. You can move, or remove it, as needed.
            this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.SONG' table. You can move, or remove it, as needed.
            this.sONGTableAdapter.Fill(this.dBLibraryDataSet.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.SONG' table. You can move, or remove it, as needed.
            this.sONGTableAdapter.Fill(this.dBLibraryDataSet.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMER' table. You can move, or remove it, as needed.
            this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMANCE' table. You can move, or remove it, as needed.
            this.pERFORMANCETableAdapter.Fill(this.dBLibraryDataSet.PERFORMANCE);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.COMPOSER' table. You can move, or remove it, as needed.
            this.cOMPOSERTableAdapter.Fill(this.dBLibraryDataSet.COMPOSER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.COMPOSER' table. You can move, or remove it, as needed.
            this.cOMPOSERTableAdapter.Fill(this.dBLibraryDataSet.COMPOSER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMANCE' table. You can move, or remove it, as needed.
            this.pERFORMANCETableAdapter.Fill(this.dBLibraryDataSet.PERFORMANCE);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMER' table. You can move, or remove it, as needed.
            this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.SONG' table. You can move, or remove it, as needed.
            this.sONGTableAdapter.Fill(this.dBLibraryDataSet.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.COMPOSER' table. You can move, or remove it, as needed.
            this.cOMPOSERTableAdapter.Fill(this.dBLibraryDataSet.COMPOSER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMER' table. You can move, or remove it, as needed.
            this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMANCE' table. You can move, or remove it, as needed.
            this.pERFORMANCETableAdapter.Fill(this.dBLibraryDataSet.PERFORMANCE);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.SONG' table. You can move, or remove it, as needed.
            this.sONGTableAdapter.Fill(this.dBLibraryDataSet.SONG);

            // TODO: This line of code loads data into the 'dBLibraryDataSet.COMPOSER' table. You can move, or remove it, as needed.
            this.cOMPOSERTableAdapter.Fill(this.dBLibraryDataSet.COMPOSER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.СSONG' table. You can move, or remove it, as needed.
            //this.сSONGTableAdapter.Fill(this.dBLibraryDataSet.СSONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMER' table. You can move, or remove it, as needed.
            this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet1.PERFORMER' table. You can move, or remove it, as needed.
            //this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet1.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMANCE' table. You can move, or remove it, as needed.
            this.pERFORMANCETableAdapter.Fill(this.dBLibraryDataSet.PERFORMANCE);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMER' table. You can move, or remove it, as needed.
            this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.SONG' table. You can move, or remove it, as needed.
            this.sONGTableAdapter.Fill(this.dBLibraryDataSet.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.СSONG' table. You can move, or remove it, as needed.
            // this.сSONGTableAdapter.Fill(this.dBLibraryDataSet.СSONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet2.PERFORMER' table. You can move, or remove it, as needed.
            this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet2.PERFORMANCE' table. You can move, or remove it, as needed.
            this.pERFORMANCETableAdapter.Fill(this.dBLibraryDataSet.PERFORMANCE);
            // TODO: This line of code loads data into the 'dBLibraryDataSet2.COMPOSER' table. You can move, or remove it, as needed.
            //this.cOMPOSERTableAdapter1.Fill(this.dBLibraryDataSet2.COMPOSER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet2.SONG' table. You can move, or remove it, as needed.
            this.sONGTableAdapter.Fill(this.dBLibraryDataSet.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet2.SONG' table. You can move, or remove it, as needed.
            //this.sONGTableAdapter1.Fill(this.dBLibraryDataSet2.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet1.SONG' table. You can move, or remove it, as needed.
            // this.sONGTableAdapter1.Fill(this.dBLibraryDataSet1.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMER' table. You can move, or remove it, as needed.
            //this.pERFORMERTableAdapter.Fill(this.dBLibraryDataSet.PERFORMER);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.PERFORMANCE' table. You can move, or remove it, as needed.
            // this.pERFORMANCETableAdapter.Fill(this.dBLibraryDataSet.PERFORMANCE);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.SONG' table. You can move, or remove it, as needed.
            //this.sONGTableAdapter.Fill(this.dBLibraryDataSet.SONG);
            // TODO: This line of code loads data into the 'dBLibraryDataSet.COMPOSER' table. You can move, or remove it, as needed.
            //this.cOMPOSERTableAdapter.Fill(this.dBLibraryDataSet.COMPOSER);

        }

        public  void ShowForm() {
            sONGTableAdapter.Update(dBLibraryDataSet.SONG);
            sONGTableAdapter.Fill(dBLibraryDataSet.SONG);
        }
        
        private void buttonSongsSave_Click(object sender, EventArgs e)
        {
            sONGTableAdapter.Update(dBLibraryDataSet.SONG);
        }

        private void buttonPerformersSave_Click(object sender, EventArgs e)
        {
            pERFORMERTableAdapter.Update(dBLibraryDataSet.PERFORMER);
        }

        private void buttonPerformancesSave_Click(object sender, EventArgs e)
        {
            pERFORMANCETableAdapter.Update(dBLibraryDataSet.PERFORMANCE);
        }

        private void SongsDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
            int numRows = SongsDataGridView.Rows.Count;
           
            if (numRows == 1) return;
            if (SongsDataGridView.Rows.Count == 2)
            {
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[0].Value = 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[3].Value = 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[5].Value = 1;
            }
            if (Convert.ToString(SongsDataGridView.Rows[numRows - 2].Cells[0].Value) == "")
            {
                SongsDataGridView.Rows[numRows - 2].Cells[0].Value = Convert.ToInt32(SongsDataGridView.Rows[numRows - 3].Cells[0].Value) + 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[3].Value = 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[5].Value = 1;
                SongsDataGridView.Rows[SongsDataGridView.Rows.Count - 2].Cells[4].Value = TimeSpan.Zero;
            }
            SetHeightdatagridview(SongsDataGridView);
        }

        private void PerformersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int numRows = PerformersDataGridView.Rows.Count;
            if (numRows == 1) return;
            if (PerformersDataGridView.Rows.Count == 2)
            {
                PerformersDataGridView.Rows[PerformersDataGridView.Rows.Count - 2].Cells[1].Value = 1;

            }
            if (Convert.ToString(PerformersDataGridView.Rows[numRows - 2].Cells[1].Value) == "")
            {
                PerformersDataGridView.Rows[numRows - 2].Cells[1].Value = Convert.ToInt32(PerformersDataGridView.Rows[numRows - 3].Cells[1].Value) + 1;
            }
            SetHeightdatagridview(PerformersDataGridView);
            //dataGridView2.Rows[numRows - 2].Cells[1].Value = numRows - 1;*/
        }

        private void PerformancesDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            
            if (PerformancesDataGridView.Rows.Count == 1) return;
            if (PerformancesDataGridView.Rows.Count == 2) PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[3].Value = 1;
            if (Convert.ToString(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[3].Value) == "")
            {
                PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[3].Value = Convert.ToInt32(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 3].Cells[3].Value) + 1;

                DataGridView dataGridView = new DataGridView();
                dataGridView = PerformancesDataGridView;

                int i = PerformancesDataGridView.CurrentCell.RowIndex;
                string s = PerformancesDataGridView[0, i - 1].Value.ToString();
                if (PerformancesDataGridView[0, i].EditedFormattedValue.ToString() == "")
                PerformancesDataGridView.Rows[i].Cells[0].Value = 1;
                if (PerformancesDataGridView[1, i].EditedFormattedValue.ToString() == "")
                PerformancesDataGridView.Rows[i].Cells[1].Value = 1;


                //PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[1].Value = Convert.ToInt32(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 3].Cells[1].Value) + 1;
                //PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 2].Cells[2].Value = Convert.ToInt32(PerformancesDataGridView.Rows[PerformancesDataGridView.Rows.Count - 3].Cells[2].Value) + 1;
            }
            SetHeightdatagridview(PerformancesDataGridView);
        }

        private void ComposersDataGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            int numRows = ComposersDataGridView.Rows.Count;
            if (numRows == 1) return;
            if (ComposersDataGridView.Rows.Count == 2)
            {
                ComposersDataGridView.Rows[ComposersDataGridView.Rows.Count - 2].Cells[1].Value = 1;

            }
            if (Convert.ToString(ComposersDataGridView.Rows[numRows - 2].Cells[1].Value) == "")
            {
                ComposersDataGridView.Rows[numRows - 2].Cells[1].Value = Convert.ToInt32(ComposersDataGridView.Rows[numRows - 3].Cells[1].Value) + 1;
            }
            SetHeightdatagridview(ComposersDataGridView);

        }

        private void buttonSongsDelete_Click(object sender, EventArgs e)
        {
            try {
                int id = (int)SongsDataGridView.CurrentRow.Cells[0].Value;

                global::System.Nullable<int> h_count = queriesTableAdapter1.ScalarQuery(id);
                if (h_count == 0)
                {
                    sONGBindingSource.RemoveCurrent();

                }
                else
                {
                    MessageBox.Show("Can not delete because performances of this song exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
                    }
            catch { }

            SetHeightdatagridview(SongsDataGridView);
        }

        private void buttonPerformersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)PerformersDataGridView.CurrentRow.Cells[1].Value;

                global::System.Nullable<int> h_count = queriesTableAdapter1.ScalarQuery2(id);
                if (h_count == 0)
                {
                    pERFORMERBindingSource.RemoveCurrent();

                }
                else
                {
                    MessageBox.Show("Can not delete because performances of this performer exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch { }
            SetHeightdatagridview(PerformersDataGridView);
        }

        private void buttonPerformancesDelete_Click(object sender, EventArgs e)
        {
            if (PerformancesDataGridView.Rows.Count == 1)
            {
                MessageBox.Show("Can not delete because list of performances is empty!", "Error", MessageBoxButtons.OK);
                return;
            }
            /*if (PerformersDataGridView.Rows.Count == PerformancesDataGridView.Rows.Count)
            {
                MessageBox.Show("Each song has to have at least one performance", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }*/
            if (date != null)
            {
                date.Visible = false;
            }
            pERFORMANCEBindingSource.RemoveCurrent();
            SetHeightdatagridview(PerformancesDataGridView);
        }

        private void PerformersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            for(int i = 0; i < PerformersDataGridView.Rows.Count; i++)
            {
                //if (Convert.ToString(PerformersDataGridView.Rows[i].Cells[2].Value) == "") PerformersDataGridView.Rows[i].Cells[2].Value = pFPLACEDataGridViewTextBoxColumn.Items[0];
            }
            int num = PerformersDataGridView.Rows.Count;
            if (num > 2)
                PerformersDataGridView.Rows[num - 1].Cells[2].Value = "";

        }

        private void buttonSongsSearch_Click(object sender, EventArgs e)
        {
            SongsADD songs = new SongsADD(SongsDataGridView.RowCount,this);
            songs.Show();
            //this.Hide();
            sONGTableAdapter.Fill(dBLibraryDataSet.SONG);
            sONGTableAdapter.Update(dBLibraryDataSet.SONG);
        }

        private void buttonPerformersSearch_Click(object sender, EventArgs e)
        {
            PerformersSearch p = new PerformersSearch();
            p.Show();
        }

        private void buttonPerformancesSearch_Click(object sender, EventArgs e)
        {
            PerformancesSearch P = new PerformancesSearch();
            P.Show();
        }

        private void buttonComposersSearch_Click(object sender, EventArgs e)
        {
            ComposersSearch c = new ComposersSearch();
            c.Show();
        }

        private void SongsDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if ((SongsDataGridView.CurrentCell.EditedFormattedValue).ToString().Length > 50) { SongsDataGridView.CurrentCell.Value = "";
                MessageBox.Show("Exceeded limit of allowed symbols","Error",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                SetHeightdatagridview(SongsDataGridView);
                return;
            }
            if (e.ColumnIndex == 4)
            {

                //MessageBox.Show("Wrong format of time, use XX:XX:XX.XXXXXXXX (first XX - hours, second XX - minutes, third XX - seconds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                System.TimeSpan s = new TimeSpan();
                if(SongsDataGridView.CurrentCell.Value.ToString()=="")
                SongsDataGridView.CurrentCell.Value = "00:00:00";

                return;
            }
        }

        private void buttonComposersSave_Click(object sender, EventArgs e)
        {
            cOMPOSERTableAdapter.Update(dBLibraryDataSet.COMPOSER);
        }

        private void buttonComposersDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = (int)ComposersDataGridView.CurrentRow.Cells[1].Value;

                global::System.Nullable<int> h_count = queriesTableAdapter1.ScalarQuery3(id);
                if (h_count == 0)
                {
                    cOMPOSERBindingSource.RemoveCurrent();

                }
                else
                {
                    MessageBox.Show("Can not delete because songs of this composer still exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch { }
            SetHeightdatagridview(ComposersDataGridView);
        }

        private void SongsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if ((SongsDataGridView.CurrentCell.EditedFormattedValue).ToString().Length > 50)
            {
                SongsDataGridView.CurrentCell.Value = "";
                MessageBox.Show("Exceeded limit of allowed symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetHeightdatagridview(SongsDataGridView);
                return;
            }

            if (!(SongsDataGridView.CurrentCell.EditedFormattedValue is System.TimeSpan))
            {
                TimeSpan time = TimeSpan.Zero;
                //TimeSpan.TryParse(SongsDataGridView.CurrentCell.FormattedValue.ToString(),out time);
                SongsDataGridView.CurrentCell.Value = time;
                return;
            }
        }
     

        private void PerformancesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (date != null)
            {
                date.Visible = false;
            }
            
            if (e.ColumnIndex == 2&&e.RowIndex!=-1)
            {

                if (e.RowIndex == PerformancesDataGridView.RowCount - 1)
                {
                    MessageBox.Show("You can not change a date without adding element!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    date = new DateTimePicker();
                    PerformancesDataGridView.Controls.Add(date);

                    date.Format = DateTimePickerFormat.Short;
                    if (PerformancesDataGridView.CurrentCell.Value.ToString() != "")
                        date.Value = (DateTime)PerformancesDataGridView.CurrentCell.Value;
                    else { date.Value = DateTime.Now;
                    }
                    Rectangle rectangle = PerformancesDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    date.Size = new Size(rectangle.Width, rectangle.Height);
                    date.Location = new Point(rectangle.X, rectangle.Y);
                    date.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                    date.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                    date.Visible = true;
                }
            }
           
            
        }

        private void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use
            date.Visible = false;
        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            PerformancesDataGridView.CurrentCell.Value = date.Text.ToString();
        }

        private void SetHeightdatagridview(DataGridView data)
        {
            data.Height = data.RowTemplate.Height * (data.Rows.Count+1);
            return;
        }


        private void SongsDataGridView_Resize(object sender, EventArgs e)
        {
            SetHeightdatagridview((DataGridView)sender);

        }

        private void PerfomersDataGridView_Resize(object sender, EventArgs e)
        {
            SetHeightdatagridview((DataGridView)sender);

        }

        private void PerformancesDataGridView_Resize(object sender, EventArgs e)
        {
            SetHeightdatagridview((DataGridView)sender);
        }

        private void ComposersDataGridView_Resize(object sender, EventArgs e)
        {
            SetHeightdatagridview((DataGridView)sender);
        }


        private void PerformancesDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if ((SongsDataGridView.CurrentCell.EditedFormattedValue).ToString().Length > 50)
            {
                SongsDataGridView.CurrentCell.Value = "";
                MessageBox.Show("Exceeded limit of allowed symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetHeightdatagridview(SongsDataGridView);
                return;
            }


            if ((PerformancesDataGridView.CurrentCell.EditedFormattedValue).ToString().Length > 50)
            {
                PerformancesDataGridView.CurrentCell.Value = "";
                MessageBox.Show("Exceeded limit of allowed symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetHeightdatagridview(PerformancesDataGridView);
                return;
            }
        }

        private void ComposersDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if ((ComposersDataGridView.CurrentCell.EditedFormattedValue).ToString().Length > 50)
            {
                ComposersDataGridView.CurrentCell.Value = "";
                MessageBox.Show("Exceeded limit of allowed symbols", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                SetHeightdatagridview(ComposersDataGridView);
                return;
            }
        }

        private void PerformersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (date != null)
            {
                date.Visible = false;
            }

            if (e.ColumnIndex == 2&&e.RowIndex!=-1)
            {

                if (e.RowIndex == PerformersDataGridView.RowCount - 1)
                {
                    MessageBox.Show("You can not change a date without adding element!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    date = new DateTimePicker();
                    PerformersDataGridView.Controls.Add(date);

                    date.Format = DateTimePickerFormat.Short;
                    if (PerformersDataGridView.CurrentCell.Value.ToString() != "")
                        date.Value = (DateTime)PerformersDataGridView.CurrentCell.Value;
                    else date.Value = DateTime.Now;
                    Rectangle rectangle = PerformersDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    date.Size = new Size(rectangle.Width, rectangle.Height);
                    date.Location = new Point(rectangle.X, rectangle.Y);
                    date.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                    date.TextChanged += new EventHandler(dateTimePicker_oOnTextChange);

                    date.Visible = true;
                }
            }

        }

        private void dateTimePicker_oOnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell
           
            PerformersDataGridView.CurrentCell.Value = date.Text.ToString();
            if ((DateTime)PerformersDataGridView.CurrentCell.Value > DateTime.Now)
            {
                MessageBox.Show("You provided a wrong date, please enter a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                PerformersDataGridView.CurrentCell.Value = DateTime.Now.ToShortDateString();

            }
        }

        private void ComposersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (date != null)
            {
                date.Visible = false;
            }

            if (e.ColumnIndex == 3&&e.RowIndex!=-1)
            {

                if (e.RowIndex == ComposersDataGridView.RowCount - 1)
                {
                    MessageBox.Show("You can not change a date without adding element!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    date = new DateTimePicker();
                    ComposersDataGridView.Controls.Add(date);

                    date.Format = DateTimePickerFormat.Short;
                    if (ComposersDataGridView.CurrentCell.Value.ToString() != "")
                        date.Value = (DateTime)ComposersDataGridView.CurrentCell.Value;
                    else date.Value = DateTime.Now;
                    Rectangle rectangle = ComposersDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                    date.Size = new Size(rectangle.Width, rectangle.Height);
                    date.Location = new Point(rectangle.X, rectangle.Y);
                    date.CloseUp += new EventHandler(oDateTimePicker_CloseUp);
                    date.TextChanged += new EventHandler(dateTimePicker_ooOnTextChange);

                    date.Visible = true;
                }
            }

        }

        private void dateTimePicker_ooOnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            ComposersDataGridView.CurrentCell.Value = date.Text.ToString();
            if ((DateTime)ComposersDataGridView.CurrentCell.Value > DateTime.Now)
            {
                MessageBox.Show("You provided a wrong date, please enter a valid date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                ComposersDataGridView.CurrentCell.Value = DateTime.Now.ToShortDateString();

            }
        }

        private void DatabaseForm_MouseMove(object sender, MouseEventArgs e)
        {
            sONGTableAdapter.Update(dBLibraryDataSet.SONG);
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            sONGTableAdapter.Update(dBLibraryDataSet.SONG);
            sONGTableAdapter.Fill(dBLibraryDataSet.SONG);
        }

        private void DatabaseForm_Activated(object sender, EventArgs e)
        {
            sONGTableAdapter.Update(dBLibraryDataSet.SONG);
            sONGTableAdapter.Fill(dBLibraryDataSet.SONG);
        }
    }
}