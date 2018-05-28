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
    public partial class IntradayDataCleaner : Form
    {
        public IntradayDataCleaner()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UIUtils.DatabaseInst.CleanIntradayData(ultraDateTimeEditor1.DateTime, ultraDateTimeEditor2.DateTime);
        }
    }
}
