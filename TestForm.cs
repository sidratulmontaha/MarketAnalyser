using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using DataModel;

namespace MarketAnalyser
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UIUtils.ProcessingInst.GetListOfStocks();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UIUtils.ProcessingInst.GetMarketDepth("BEXIMCO");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.WriteEODSnapshotToDB(UIUtils.ProcessingInst.GetAllSnapshots());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.ReadSnapshotFromDB();
        }


        private void button7_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.DeleteSnapshotFromDB(DateTime.Now);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.CleanupDatabase();
        }

        private void button6_Click(object sender, EventArgs e)
        {
        }

        private void button9_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.WriteIntradaySnapshotToDB(UIUtils.ProcessingInst.GetAllSnapshots());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //UIUtils.DatabaseInst.GetListOfIntradaySnapshots();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            DateTime dt1 = new DateTime(2014, 11, 16, 7, 55, 10);
            DateTime dt2 = new DateTime(2014, 11, 16, 8, 25, 10);
            UIUtils.DatabaseInst.ReadIntradaySnapshotFromDB(dt1, dt2, IntradaySnapshotReaderModes.StockOnly, "ABBANK");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            MSTStockInfo i = UIUtils.ProcessingInst.GetIndexOpenClose()[1];
            UIUtils.ProcessingInst.GetDSESHighLow(ref i);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            UIUtils.ProcessingInst.GetMarketDepthNew("USMANIAGL");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.WriteIntradaySnapshotToDBNew(UIUtils.ProcessingInst.GetAllSnapshotsNew());
        }
    }
}
