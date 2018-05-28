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
using Infragistics.UltraChart.Resources.Appearance;

namespace MarketAnalyser
{
    public partial class BuyerSellerPriceChart : Form
    {
        public BuyerSellerPriceChart()
        {
            InitializeComponent();
        }

        private void BuyerSellerPriceChart_Load(object sender, EventArgs e)
        {
            List<string> Stocks = new List<string>();

            Stocks = UIUtils.ProcessingInst.GetListOfStocks();

            comboBox1.DataSource = Stocks;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ultraChart1.CompositeChart.ChartLayers[0].Series.Clear();
            ultraChart1.CompositeChart.ChartLayers[1].Series.Clear();

            List<SnapshotRecordNew> Record = UIUtils.DatabaseInst.ReadIntradaySnapshotFromDBNew(
                ultraDateTimeEditor1.DateTime, ultraDateTimeEditor2.DateTime,
                IntradaySnapshotReaderModes.StockAndBetweenDateTime, comboBox1.Text);

            NumericTimeSeries PS;
            NumericTimeSeries BVS;
            NumericTimeSeries SVS;
            NumericTimeSeries VS;
            NumericTimeSeries BSR;

            GetAllSeriesFromRecord(Record, out PS, out BVS, out SVS, out VS, out BSR);

            if(PC.Checked)
                ultraChart1.CompositeChart.ChartLayers[0].Series.Add(PS);

            if(BVC.Checked)
                ultraChart1.CompositeChart.ChartLayers[1].Series.Add(BVS);

            if(SVC.Checked)
                ultraChart1.CompositeChart.ChartLayers[1].Series.Add(SVS);

            if(VC.Checked)
                ultraChart1.CompositeChart.ChartLayers[1].Series.Add(VS);

            if (BSRt.Checked)
                ultraChart1.CompositeChart.ChartLayers[1].Series.Add(BSR);

            ultraChart1.CompositeChart.ChartLayers[0].AxisX.ScrollScale.Visible = true;
            ultraChart1.CompositeChart.ChartLayers[1].AxisX.ScrollScale.Visible = true;
        }

        private void GetAllSeriesFromRecord(List<SnapshotRecordNew> Record, out NumericTimeSeries PriceSeries,
            out NumericTimeSeries BuyerVolumeSeries, out NumericTimeSeries SellerVolumeSeries, 
            out NumericTimeSeries VolumeSeries, out NumericTimeSeries BuyerSellerRatioSeries)
        {
            NumericTimeSeries PS = new NumericTimeSeries();
            NumericTimeSeries BVS = new NumericTimeSeries();
            NumericTimeSeries SVS = new NumericTimeSeries();
            NumericTimeSeries VS = new NumericTimeSeries();
            NumericTimeSeries BSR = new NumericTimeSeries();

            PS.Label = "Price";
            BVS.Label = "Buyer Volume";
            SVS.Label = "Seller Volume";
            VS.Label = "Volume";
            BSR.Label = "Buyer Seller Ratio";

            List<EODSnapshotAggregateNew> Aggregates = UIUtils.ProcessingInst.GetAggregateSnapshotNew(Record);

            double PP, VP;
            float TBVP, TSVP;
            float BSRatio;

            for (ushort i = 0; i < Aggregates.Count; i++)
            {
                try
                {
                    PP = (Aggregates[i].LastTradePrice == 0)
                        ? (Aggregates[i - 1].LastTradePrice)
                        : Aggregates[i].LastTradePrice;

                    VP = (Aggregates[i].TotalVolume == 0)
                        ? (Aggregates[i - 1].TotalVolume)
                        : Aggregates[i].TotalVolume;

                    TBVP = (Aggregates[i].TotalBuyerVolume == 0)
                        ? (Aggregates[i - 1].TotalBuyerVolume)
                        : Aggregates[i].TotalBuyerVolume;

                    TSVP = (Aggregates[i].TotalSellerVolume == 0)
                        ? (Aggregates[i - 1].TotalSellerVolume)
                        : Aggregates[i].TotalSellerVolume;

                    BSRatio = (Aggregates[i].BuyerSellerRatio == 0) || (Aggregates[i].BuyerSellerRatio > 100)
                        ? (Aggregates[i - 1].BuyerSellerRatio)
                        : Aggregates[i].BuyerSellerRatio;
                    
                    PS.Points.Add(new NumericTimeDataPoint(DateTime.Parse(Aggregates[i].Date), PP, "", false));
                    BVS.Points.Add(new NumericTimeDataPoint(DateTime.Parse(Aggregates[i].Date), double.Parse(TBVP.ToString()), "", false));
                    SVS.Points.Add(new NumericTimeDataPoint(DateTime.Parse(Aggregates[i].Date), double.Parse(TSVP.ToString()), "", false));
                    VS.Points.Add(new NumericTimeDataPoint(DateTime.Parse(Aggregates[i].Date), VP, "", false));
                    BSR.Points.Add(new NumericTimeDataPoint(DateTime.Parse(Aggregates[i].Date), BSRatio, "", false));
                }
                catch (Exception )
                {
                    
                }
            }

            PS.PEs.Add(new PaintElement(Color.LawnGreen));
            BVS.PEs.Add(new PaintElement(Color.Indigo));
            SVS.PEs.Add(new PaintElement(Color.OrangeRed));
            VS.PEs.Add(new PaintElement(Color.Blue));
            BSR.PEs.Add(new PaintElement(Color.Coral));

            PriceSeries = PS;
            BuyerVolumeSeries = BVS;
            SellerVolumeSeries = SVS;
            VolumeSeries = VS;
            BuyerSellerRatioSeries = BSR;
        }
    }
}
