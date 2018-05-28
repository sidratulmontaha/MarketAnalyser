using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DataModel;

namespace MarketAnalyser
{
    public partial class IntradayRecorder : Form
    {
        private DateTime StartTime;// = new DateTime(2014, 11, 23, 2, 15, 00);
        private DateTime EndTime;// = new DateTime(2014, 11, 23, 08, 35, 00);

        public IntradayRecorder()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime Start = ultraDateTimeEditor1.DateTime;
            DateTime End = ultraDateTimeEditor2.DateTime;

            DateTime Now = DateTime.Now;

            StartTime = Start;//new DateTime(Now.Year, Now.Month, Now.Day, Start.Hour, Start.Minute, Start.Second);
            EndTime = End;//new DateTime(Now.Year, Now.Month, Now.Day, End.Hour, End.Minute, End.Second);

            timer1.Interval = int.Parse(textBox2.Text) * 1000;

            timer1_Tick(sender, e);
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
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
                    Dictionary<string, Tuple<List<MarketDepthUnit>, string, string>> Snapshots =
                        UIUtils.ProcessingInst.GetAllSnapshots();

                    UpdateConsole("Writing All Snapshots to SQLite DB... " + DateTime.Now.ToLongTimeString());

                    UIUtils.DatabaseInst.WriteIntradaySnapshotToDB(Snapshots);
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

        void UpdateConsole(string Line)
        {
            textBox1.AppendText(Environment.NewLine + Line);
        }

        private void IntradayRecorder_Load(object sender, EventArgs e)
        {

        }
    }
}
