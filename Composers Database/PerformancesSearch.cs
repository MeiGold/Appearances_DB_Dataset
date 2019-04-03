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
    public partial class PerformancesSearch : Form
    {
        public PerformancesSearch()
        {
            InitializeComponent();
        }

        private void find()
        {
            DateTime from = DateFrom.Value;
            DateTime to = DateTo.Value;
           
            
                pERFORMANCESearchTableAdapter.ClearBeforeFill = true;
                pERFORMANCESearchTableAdapter.Fill(dBLibraryDataSet.PERFORMANCESearch, to.ToString(), from.ToString());

            
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            find();
        }
    }
}
