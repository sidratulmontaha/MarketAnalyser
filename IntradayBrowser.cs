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
using Infragistics.Win.UltraWinTree;

namespace MarketAnalyser
{
    public partial class IntradayBrowser : Form
    {
        public IntradayBrowser()
        {
            InitializeComponent();
        }

        private void IntradayBrowser_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = UIUtils.DatabaseInst.GetListOfDatesIntradayDataAvailableNew();
            comboBox1.Text = comboBox1.Items[0].ToString();
            ultraTree1.DataSource = UIUtils.DatabaseInst.GetListOfIntradaySnapshotsNew(comboBox1.Text);
        }

        private void ultraTree1_AfterSelect(object sender, SelectEventArgs e)
        {
            if (e.NewSelections.Count == 0) return;

            DateTime temp;
            string Text = e.NewSelections[0].Text;
            List<SnapshotRecordNew> Record = new List<SnapshotRecordNew>();

            if (DateTime.TryParse(Text, out temp))
            {
                Record = UIUtils.DatabaseInst.ReadIntradaySnapshotFromDBNew(temp, temp,
                    IntradaySnapshotReaderModes.StockAndDateTime,
                    e.NewSelections[0].Parent.Text);

                PopulateMarketDepth(Record[0]);
            }
        }

        private void PopulateMarketDepth(SnapshotRecordNew Record)
        {
            List<MarketDepthUnit> MarketDepthData = Record.MarketDepthSnapshot;
            List<MarketDepthUnit> BuyerMarketDepths =
                MarketDepthData.Where((x) => (x.Type == MarketDepthType.Buyer))
                    .OrderByDescending((y) => y.Price)
                    .ToList();
            List<MarketDepthUnit> SellerMarketDepths =
                MarketDepthData.Where((x) => (x.Type == MarketDepthType.Seller)).OrderBy((y) => y.Price).ToList();

            for (byte i = 1; i <= 10; i++)
            {
                ((Label)Controls["BP" + i]).Text = "0";
                ((Label)Controls["BV" + i]).Text = "0";
                ((Label)Controls["SP" + i]).Text = "0";
                ((Label)Controls["SV" + i]).Text = "0";
            }

            for (byte i = 1; i <= BuyerMarketDepths.Count; i++)
            {
                ((Label) Controls["BP" + i]).Text = BuyerMarketDepths[i - 1].Price.ToString();
                ((Label) Controls["BV" + i]).Text = BuyerMarketDepths[i - 1].Volume.ToString();
            }

            for (byte i = 1; i <= SellerMarketDepths.Count; i++)
            {
                ((Label) Controls["SP" + i]).Text = SellerMarketDepths[i - 1].Price.ToString();
                ((Label) Controls["SV" + i]).Text = SellerMarketDepths[i - 1].Volume.ToString();
            }

            P.Text = Record.OpenPrice.ToString();
            label10.Text = Record.LastTradePrice.ToString();
            V.Text = Record.YesterdayClosePrice.ToString();
            label9.Text = Record.ClosePrice.ToString();
            label18.Text = Record.DayHigh.ToString();
            label14.Text = Record.DayLow.ToString();
            label17.Text = Record.NoOfTrade.ToString();
            label13.Text = Record.TotalVolume.ToString();
            label21.Text = Record.TotalValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ultraTree1.DataSource = UIUtils.DatabaseInst.GetListOfIntradaySnapshotsNew(comboBox1.Text);
        }
    }
}
