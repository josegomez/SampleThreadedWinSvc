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
                string source = "DemoServiceAppLog";
                string log = "Application";
                if (!EventLog.SourceExists(source))
                {
                    EventLog.CreateEventSource(source, log);
                }
                EventLog.WriteEntry(source, "Demo Service Doing Work", EventLogEntryType.Information);
                Thread.Sleep(30000);
            }
        }
    }
}
