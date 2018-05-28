using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ProcessingLayer;

namespace MarketAnalyser
{
    public static class UIUtils
    {
        public static DataAccessLayer.DatabaseLayer DatabaseInst;
        public static ProcessingLayer.ProcessingLayer ProcessingInst;
        public static DataAccessLayer.DataAccessLayer DataAccessInst;

        public static void InitialiseDBConnection(string DatabasePath)
        {
            DatabaseInst = new DataAccessLayer.DatabaseLayer(DatabasePath);
            ProcessingInst = new ProcessingLayer.ProcessingLayer(DatabaseInst);
            DataAccessInst = new DataAccessLayer.DataAccessLayer();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (var stream = client.OpenRead("http://www.google.com"))
                {
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }

    
}
