using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class frm_WaitForm : Form
    {
       
        public Action Worker { get; set; }
        public frm_WaitForm(Action worker)
        {
            InitializeComponent();
            if (worker == null)
                throw new ArgumentException();
            Worker = worker;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(t => { this.Close(); }, TaskScheduler.FromCurrentSynchronizationContext());
        }
        private void processbartime_Tick(object sender, EventArgs e)
        {
            if (processbar.Width != toppanel.Width)
            {
                processbar.Width = processbar.Width + 4;
            }
        }
        private void frm_WaitForm_Load(object sender, EventArgs e)
        {
            processbartime.Start();
        }
    }
}
