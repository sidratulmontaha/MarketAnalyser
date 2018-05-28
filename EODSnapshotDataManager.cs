using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAnalyser
{
    public partial class EODSnapshotDataManager : Form
    {
        public EODSnapshotDataManager()
        {
            InitializeComponent();
        }

        private void EODSnapshotDataManager_Load(object sender, EventArgs e)
        {
            PopulateList();
        }

        private void PopulateList()
        {
            List<string> Dates = UIUtils.DatabaseInst.GetAllDatesDataAvailable();

            listBox1.Items.Clear();

            foreach (string Item in Dates)
            {
                listBox1.Items.Add(Item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Contains(DateTime.Now.ToString("yyyy-MM-dd")))
                return;

            UIUtils.DatabaseInst.WriteEODSnapshotToDB(UIUtils.ProcessingInst.GetAllSnapshots());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                UIUtils.DatabaseInst.DeleteSnapshotFromDB(DateTime.Parse(listBox1.SelectedItem.ToString()));

                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PopulateList();
        }
    }
}
