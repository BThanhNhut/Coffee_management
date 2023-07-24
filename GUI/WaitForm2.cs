using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_WaitForm2 : Form
    {
        public frm_WaitForm2()
        {
            InitializeComponent();
        }
        
        public Action Worker { get; set; }
        public frm_WaitForm2(Action worker)
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
    }
}
