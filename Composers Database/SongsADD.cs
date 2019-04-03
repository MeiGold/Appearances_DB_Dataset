using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Composers_Database
{
    public partial class SongsADD : Form
    {
        public int lld;
        DatabaseForm dd;
        public SongsADD(int lid, DatabaseForm d)
        {
            dd = d;
            InitializeComponent();
            lld = lid;
            for(int i = 0; i < ComposerComboBox.Items.Count; i++)
            {
                ComposerComboBox.Items[i] = "i - " + ComposerComboBox.Items[i];            }
            }

        private void ButtonADD_Click(object sender, EventArgs e)
        {
            if (CompositorTextBox.Text != "" && NameTextBox.Text != "" && GenreTextBox.Text != "" && DurationTextBox.Text != "")
            {
                try
                {
                    int s;
                    string c_id = CompositorTextBox.Text;
                    string name = NameTextBox.Text;
                    string genre = GenreTextBox.Text;
                    
                
                    TimeSpan time;
                    if (!Int32.TryParse(c_id, out s))
                    {
                        throw new Exception();
                    }
                    if(!
                    TimeSpan.TryParse(DurationTextBox.Text, out time))
                    {
                        throw new Exception();
                    }
                    if (c_id == "" || name == "" || genre == "" || time.ToString() == "")
                    {
                        MessageBox.Show("You have not entered all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        throw new Exception();
                    }
                    string ss = time.ToString();
                    queriesTableAdapter1.InsertQuery(lld, c_id, name, genre, time.ToString());

                    songTableAdapter.Update(dbLibraryDataSet.SONG);
                    songTableAdapter.Fill(dbLibraryDataSet.SONG);
                    //songTableAdapter.Insert(lld, c_id, name, genre, time,0);
                    this.Close();
                    
                    
                    //DatabaseForm.ActiveForm.Update();
                }
                catch { MessageBox.Show("Fatal error! You probably entered wrong duration of song.", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Stop);
                    this.Close();
                }
               
                
            }      else MessageBox.Show("You have not entered all the fields!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void SongsADD_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'dbLibraryDataSet.COMPOSER' table. You can move, or remove it, as needed.
            this.cOMPOSERTableAdapter.Fill(this.dbLibraryDataSet.COMPOSER);
            
        }
    }
}
