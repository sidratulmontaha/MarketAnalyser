using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

namespace MarketAnalyser
{
    public partial class EODSnapshotViewer : Form
    {
        public EODSnapshotViewer()
        {
            InitializeComponent();
        }

        void PopulateDropdown()
        {
            List<string> Dates = UIUtils.DatabaseInst.GetAllDatesDataAvailable();

            foreach (string Item in Dates)
            {
                comboBox1.Items.Add(Item);
            }
        }

        private void EODSnapshotViewer_Load(object sender, EventArgs e)
        {
            PopulateDropdown();
            comboBox1.SelectedItem = comboBox1.Items[0];
            ultraGrid1.DisplayLayout.Override.AllowMultiCellOperations =
                                    AllowMultiCellOperation.Copy | AllowMultiCellOperation.Paste;
            ultraGrid1.DisplayLayout.Override.AllowRowFiltering = DefaultableBoolean.True;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<SnapshotRecord> Records = UIUtils.DatabaseInst.ReadSnapshotFromDB(DateTime.Parse(comboBox1.Text));

            ultraGrid1.DataSource = UIUtils.ProcessingInst.GetAggregateSnapshot(Records);
            ultraGrid1.DataBind();
        }
    }
}
