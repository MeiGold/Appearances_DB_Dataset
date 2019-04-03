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
    public partial class ComposersSearch : Form
    {
        string name;
        string nationality;
        public ComposersSearch()
        {
            InitializeComponent();
        }
        private void find()
        {
            name = "%" + NameTextBox.Text + "%";
            nationality = "%" + NationalityTextBox.Text + "%";
            if (NameTextBox.Text == "" || NationalityTextBox.Text == "")
            {
                cOMPOSERSearchTableAdapter.FillBy(dBLibraryDataSet.COMPOSERSearch);
            }
            if (NameTextBox.Text != "" || NationalityTextBox.Text != "")
            {
                cOMPOSERSearchTableAdapter.ClearBeforeFill = true;
                cOMPOSERSearchTableAdapter.Fill(dBLibraryDataSet.COMPOSERSearch, name, nationality);

            }

        }
        private void SearchButton_Click(object sender, EventArgs e)
        {
            cOMPOSERSearchTableAdapter.ClearBeforeFill = true;
            find();
        }
    }
}
