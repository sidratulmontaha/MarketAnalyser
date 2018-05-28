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
    public partial class IntradayRecorderRevamp : Form
    {
        private DateTime StartTime;
        private DateTime EndTime;

        public IntradayRecorderRevamp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Start = ultraDateTimeEditor1.DateTime;
            DateTime End = ultraDateTimeEditor2.DateTime;

            DateTime Now = DateTime.Now;

            StartTime = Start;
            EndTime = End;

            timer1.Interval = int.Parse(textBox2.Text) * 1000;

            timer1_Tick_1(sender, e);
            timer1.Enabled = true;
        }

        void UpdateConsole(string Line)
        {
            textBox1.AppendText("\r\n" + DateTime.Now + ": " + Line);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            DateTime Current = DateTime.Now;

            if (!UIUtils.CheckForInternetConnection())
            {
                UpdateConsole("No internet connection... " + DateTime.Now.ToLongTimeString());
                return;
            }

            try
            {
                if ((Current > StartTime) && (Current < EndTime))
                {
                    UpdateConsole("Getting All Snapshots... " + DateTime.Now.ToLongTimeString());
                    Dictionary<string, Tuple<List<MarketDepthUnit>, ExtraMarketDepthData>> Snapshots =
                        UIUtils.ProcessingInst.GetAllSnapshotsNew();

                    UpdateConsole("Writing All Snapshots to SQLite DB... " + DateTime.Now.ToLongTimeString());

                    UIUtils.DatabaseInst.WriteIntradaySnapshotToDBNew(Snapshots);
                    UpdateConsole("Finished!!! " + DateTime.Now.ToLongTimeString());
                }
                else
                {
                    UpdateConsole("Outside trade hour...Doing nothing... " + DateTime.Now.ToLongTimeString());
                }
            }
            catch (Exception)
            {
                UpdateConsole("Error occurred while writing... " + DateTime.Now.ToLongTimeString());
            }
        }

        private void IntradayRecorderRevamp_Load(object sender, EventArgs e)
        {
            DateTime NowTime = DateTime.Now;

            DateTime UTCStartTime = new DateTime(NowTime.Year, NowTime.Month, NowTime.Day, 4, 25, 0);
            DateTime StartTime = TimeZone.CurrentTimeZone.ToLocalTime(UTCStartTime);

            DateTime UTCEndTime = new DateTime(NowTime.Year, NowTime.Month, NowTime.Day, 8, 35, 0);
            DateTime EndTime = TimeZone.CurrentTimeZone.ToLocalTime(UTCEndTime);

            ultraDateTimeEditor1.DateTime = StartTime;
            ultraDateTimeEditor2.DateTime = EndTime;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime WhichDay = ultraDateTimeEditor1.DateTime;

            try
            {
                string DestinationPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\MarketData\\" +
                                         "MARKETDATA_" +
                                         WhichDay.ToString("dd_MM_yy") + ".DB";
                File.Copy("MarketDataOriginal.db", DestinationPath);
                UIUtils.InitialiseDBConnection(DestinationPath);
            }
            catch (Exception)
            {
                UpdateConsole(
                    "Error while creating file. Check if MarketData folder exists in Desktop and MarketDataOriginal.db fiile is not missing or destination file already exists");
            }
        }
    }
}
