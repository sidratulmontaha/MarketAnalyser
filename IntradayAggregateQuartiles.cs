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
    public partial class IntradayAggregateQuartiles : Form
    {
        public IntradayAggregateQuartiles()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ultraGrid1.DataSource =
                UIUtils.ProcessingInst.GetDescriptiveStatistics(ultraDateTimeEditor1.DateTime,
                    ultraDateTimeEditor2.DateTime)
                    .Select(
                        x =>
                            new
                            {
                                x.Instrument,
                                MedianRatio = x.Ratios.Median,
                                BuyerMedian = x.TBVDescriptiveStatistics.Median,
                                SellerMedian = x.TSVDescriptiveStatistics.Median,
                                LQRatio = x.Ratios.LowerQuartile,
                                BuyerLQ = x.TBVDescriptiveStatistics.LowerQuartile,
                                SellerLQ = x.TSVDescriptiveStatistics.LowerQuartile,
                                UQRatio = x.Ratios.UpperQuartile,
                                BuyerUQ = x.TBVDescriptiveStatistics.UpperQuartile,
                                SellerUQ = x.TSVDescriptiveStatistics.UpperQuartile,
                                MinRatio = x.Ratios.Minimum,
                                BuyerMin = x.TBVDescriptiveStatistics.Minimum,
                                SellerMin = x.TSVDescriptiveStatistics.Minimum,
                                MaxRatio = x.Ratios.Maximum,
                                BuyerMax = x.TBVDescriptiveStatistics.Maximum,
                                SellerMax = x.TSVDescriptiveStatistics.Maximum
                            }).ToList();
        }
    }
}
