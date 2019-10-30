using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadedServiceSample
{
    public partial class svcSample : ServiceBase
    {
        private bool running = false;
        Thread thWorker = null;
        public svcSample()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            running = true;
            thWorker = new Thread(DoWork);
            thWorker.Start();
        }

        protected override void OnStop()
        {
            running = false;
        }

        private void DoWork()
        {
            while(running)
            {
                using (EventLog eventLog = new EventLog("Application"))
                {
                    eventLog.Source = "Application";
                    eventLog.WriteEntry("Service Loop", EventLogEntryType.Information, 101, 1);
                }
                Thread.Sleep(30000);
            }
        }
    }
}
