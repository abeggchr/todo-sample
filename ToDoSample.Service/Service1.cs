using System;
using System.ServiceProcess;

using Microsoft.Owin.Hosting;

using ToDoSample.WebApi;

namespace ToDoSample.Service
{
    /// <summary>
    /// The service 1.
    /// </summary>
    public partial class Service1 : ServiceBase
    {
        private IDisposable app;

        /// <summary>
        /// Initializes a new instance of the <see cref="Service1"/> class.
        /// </summary>
        public Service1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The on start.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        protected override void OnStart(string[] args)
        {
            string baseAddress = Properties.Settings.Default.BaseAddress;
            this.app = WebApp.Start<Startup>(url: baseAddress);
        }

        /// <summary>
        /// The on stop.
        /// </summary>
        protected override void OnStop()
        {
            this.app.Dispose();
        }
    }
}
