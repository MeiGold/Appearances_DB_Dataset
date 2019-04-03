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
    public partial class PerformersSearch : Form
    {
        string name;
        string nationality;
        public PerformersSearch()
        {
            InitializeComponent();

        }
        private void find()
        {
            name = "%" + NameTextBox.Text + "%";
            nationality = "%" + NationalityTextBox.Text + "%";
            if(NameTextBox.Text == "" || NationalityTextBox.Text == "")
            {
                pERFORMERSearchTableAdapter.FillBy(dBLibraryDataSet.PERFORMERSearch);
            }
            if (NameTextBox.Text != "" || NationalityTextBox.Text != "")
            {
                if (NameTextBox.Text == null) name = null;
                if (NationalityTextBox.Text == null) nationality = null;
                pERFORMERSearchTableAdapter.ClearBeforeFill = true;
                pERFORMERSearchTableAdapter.Fill(dBLibraryDataSet.PERFORMERSearch, name, nationality);

            }
            
        }

        private void ButtonFind_Click(object sender, EventArgs e)
        {
            find();
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            find();
        }

        private void NationalityTextBox_TextChanged(object sender, EventArgs e)
        {
            find();
        }
    }
}
