using System;
using System.ServiceProcess;

using Microsoft.Owin.Hosting;

using ToDoSample.WebApi;

namespace ToDoSample.Service
{
    /// <summary>
    /// The service 1.
    /// </summary>
    public partial class ToDoSampleService : ServiceBase
    {
        private IDisposable app;

        /// <summary>
        /// Initializes a new instance of the <see cref="ToDoSampleService"/> class.
        /// </summary>
        public ToDoSampleService()
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
            if (this.app != null)
            {
                this.app.Dispose();
            }
        }
    }
}
