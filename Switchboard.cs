using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketAnalyser
{
    public partial class Switchboard : Form
    {
        public Switchboard()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EODSnapshotDataManager f = new EODSnapshotDataManager();
            f.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EODSnapshotViewer f = new EODSnapshotViewer();
            f.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TestForm f = new TestForm();
            f.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IntradayBrowser f = new IntradayBrowser();
            f.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntradayRecorder f = new IntradayRecorder();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuyerSellerPriceChart f = new BuyerSellerPriceChart();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IntradayDataCleaner f = new IntradayDataCleaner();
            f.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.CleanupDatabase();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DataDownloader f = new DataDownloader();
            f.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            IntradayRecorderRevamp f = new IntradayRecorderRevamp();
            f.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            IntradayAggregateQuartiles f = new IntradayAggregateQuartiles();
            f.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            IntradayAggregateQuartilesGraph f = new IntradayAggregateQuartilesGraph();
            f.Show();
        }

        private void Switchboard_Load(object sender, EventArgs e)
        {
            textBox1.Text =
                Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MarketData\\")
                    .ElementAtOrDefault(0);

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                                               "\\MarketData\\";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DialogResult Result = openFileDialog1.ShowDialog();
            if (Result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            UIUtils.InitialiseDBConnection(textBox1.Text);
        }
    }
}
