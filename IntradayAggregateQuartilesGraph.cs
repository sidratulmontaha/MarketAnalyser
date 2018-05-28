using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using Infragistics.UltraChart.Resources;
using Infragistics.UltraChart.Resources.Appearance;

namespace MarketAnalyser
{
    public partial class IntradayAggregateQuartilesGraph : Form
    {
        public IntradayAggregateQuartilesGraph()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ultraChart1.CompositeChart.ChartLayers[0].Series.Clear();
            ultraChart1.CompositeChart.ChartLayers[1].Series.Clear();

            List<IntradayDescriptiveStatistics> Stats =
                UIUtils.ProcessingInst.GetDescriptiveStatistics(ultraDateTimeEditor1.DateTime,
                    ultraDateTimeEditor2.DateTime);

            BoxSetSeries BuyerSeries = new BoxSetSeries();
            BoxSetSeries SellerSeries = new BoxSetSeries();

            foreach (IntradayDescriptiveStatistics SingleStat in Stats)
            {
                BuyerSeries.BoxSets.Add(new BoxSet(SingleStat.Instrument,
                    double.IsNaN(SingleStat.TBVDescriptiveStatistics.Minimum)
                        ? 0
                        : SingleStat.TBVDescriptiveStatistics.Minimum,
                    double.IsNaN(SingleStat.TBVDescriptiveStatistics.LowerQuartile)
                        ? 0
                        : SingleStat.TBVDescriptiveStatistics.LowerQuartile,
                    double.IsNaN(SingleStat.TBVDescriptiveStatistics.Median)
                        ? 0
                        : SingleStat.TBVDescriptiveStatistics.Median,
                    double.IsNaN(SingleStat.TBVDescriptiveStatistics.UpperQuartile)
                        ? 0
                        : SingleStat.TBVDescriptiveStatistics.UpperQuartile,
                    double.IsNaN(SingleStat.TBVDescriptiveStatistics.Maximum)
                        ? 0
                        : SingleStat.TBVDescriptiveStatistics.Maximum));

                SellerSeries.BoxSets.Add(new BoxSet(SingleStat.Instrument,
                    double.IsNaN(SingleStat.TSVDescriptiveStatistics.Minimum)
                        ? 0
                        : SingleStat.TSVDescriptiveStatistics.Minimum,
                    double.IsNaN(SingleStat.TSVDescriptiveStatistics.LowerQuartile)
                        ? 0
                        : SingleStat.TSVDescriptiveStatistics.LowerQuartile,
                    double.IsNaN(SingleStat.TSVDescriptiveStatistics.Median)
                        ? 0
                        : SingleStat.TSVDescriptiveStatistics.Median,
                    double.IsNaN(SingleStat.TSVDescriptiveStatistics.UpperQuartile)
                        ? 0
                        : SingleStat.TSVDescriptiveStatistics.UpperQuartile,
                    double.IsNaN(SingleStat.TSVDescriptiveStatistics.Maximum)
                        ? 0
                        : SingleStat.TSVDescriptiveStatistics.Maximum));
            }

            BuyerSeries.PEs.Add(new PaintElement(Color.Green));
            SellerSeries.PEs.Add(new PaintElement(Color.Red));

            if(checkBox1.Checked)
                ultraChart1.CompositeChart.ChartLayers[0].Series.Add(BuyerSeries);

            if(checkBox2.Checked)
                ultraChart1.CompositeChart.ChartLayers[1].Series.Add(SellerSeries);

            ultraChart1.CompositeChart.ChartLayers[0].AxisX.ScrollScale.Visible = true;
            ultraChart1.CompositeChart.ChartLayers[1].AxisX.ScrollScale.Visible = true;

            Hashtable ToolTip = new Hashtable();
            ToolTip.Add("CUSTOM", new CustomToolTip());

            ultraChart1.LabelHash = ToolTip;
        }

        public class CustomToolTip : IRenderLabel
        {
            public string ToString(Hashtable context)
            {
                return context["ITEM_LABEL"].ToString();
            }
        }
    }
}
