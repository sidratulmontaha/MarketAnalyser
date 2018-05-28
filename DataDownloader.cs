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
using DataModel;

namespace MarketAnalyser
{
    public partial class DataDownloader : Form
    {
        public DataDownloader()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            {
                List<MSTStockInfo> MSTInfo = new List<MSTStockInfo>();

                UpdateStatus("Getting Stock information from MST File...");

                MSTInfo = UIUtils.ProcessingInst.GetAllStockInfoFromMST();

                MSTStockInfo[] IndexInfo = new MSTStockInfo[3];

                UpdateStatus("Getting Index Open/Close and Volume from DSE Home Page...");

                IndexInfo = UIUtils.ProcessingInst.GetIndexOpenClose().ToArray();

                UpdateStatus("Getting DSEX High/Low...");

                UIUtils.ProcessingInst.GetDSEXHighLow(ref IndexInfo[0]);

                UpdateStatus("Checking if DSEX and MST Dates match...");

                if (!UIUtils.ProcessingInst.DoesMSTAndDSEXDateMatch())
                {
                    UpdateStatus("DSEX and MST Dates do not match! Try again later once MST file is updated");
                    UpdateStatus("Download Aborted");
                    return;
                }

                UpdateStatus("DSEX and MST Dates match! Continuing with Download...");
                
                UpdateStatus("Getting DSES High/Low...");

                UIUtils.ProcessingInst.GetDSESHighLow(ref IndexInfo[1]);

                UpdateStatus("Getting DS30 High/Low...");

                UIUtils.ProcessingInst.GetDS30HighLow(ref IndexInfo[2]);

                MSTInfo.AddRange(IndexInfo);

                UpdateStatus("Preparing CSV...");

                string CSVData = UIUtils.ProcessingInst.PrepareCSVFromStockInfo(MSTInfo);

                UpdateStatus("Writing CSV to Desktop...");

                UIUtils.ProcessingInst.WriteCSV(CSVData);

                UpdateStatus("Done!!!");
            }
            //catch (Exception ex)
            //{
            //    UpdateStatus("ERROR: " + ex.Message + "\r\n" + ex.StackTrace);
            //}
        }

        private void UpdateStatus(string Status)
        {
            textBox1.AppendText("\r\n" + DateTime.Now + ": " + Status);
        }
    }
}
