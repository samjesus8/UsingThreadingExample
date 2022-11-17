using System;
using System.Windows.Forms;

namespace ThreadingExample
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void backgroundThread_Click(object sender, EventArgs e)
        {
            var Form = new BackgroundWorker();
            Form.Show();
        }

        private void threadPool_Click(object sender, EventArgs e)
        {

        }
    }
}
