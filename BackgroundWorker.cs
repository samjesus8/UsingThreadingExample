using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ThreadingExample
{
    public partial class BackgroundWorker : Form
    {
        private int numberToCompute = 0;
        private int highestPercentageReached = 0;

        public BackgroundWorker()
        {
            InitializeComponent();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.WorkerSupportsCancellation = true;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            stopButton.Enabled = true;
            startButton.Enabled = false;
            highestPercentageReached = 0;
            numberToCompute = (int)numberBox.Value;

            if(backgroundWorker1.IsBusy != true) 
            {
                backgroundWorker1.RunWorkerAsync(numberToCompute);
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if(backgroundWorker1.WorkerSupportsCancellation == true) 
            {
                backgroundWorker1.CancelAsync();
            }
        }

        public long ComputeFibonacci(int n, System.ComponentModel.BackgroundWorker worker, DoWorkEventArgs e)
        {
            // The parameter n must be >= 0 and <= 91.
            // Fib(n), with n > 91, overflows a long.
            if ((n < 0) || (n > 91))
            {
                throw new ArgumentException(
                    "value must be >= 0 and <= 91", "n");
            }

            long result = 0;

            // Abort the operation if the user has canceled.
            // Note that a call to CancelAsync may have set 
            // CancellationPending to true just after the
            // last invocation of this method exits, so this 
            // code will not have the opportunity to set the 
            // DoWorkEventArgs.Cancel flag to true. This means
            // that RunWorkerCompletedEventArgs.Cancelled will
            // not be set to true in your RunWorkerCompleted
            // event handler. This is a race condition.

            if (worker.CancellationPending)
            {
                e.Cancel = true;
            }
            else
            {
                if (n < 2)
                {
                    result = 1;
                }
                else
                {
                    result = ComputeFibonacci(n - 1, worker, e) +
                             ComputeFibonacci(n - 2, worker, e);
                }

                // Report progress as a percentage of the total task.
                int percentComplete =
                    (int)((float)n / (float)numberToCompute * 100);
                if (percentComplete > highestPercentageReached)
                {
                    highestPercentageReached = percentComplete;
                    worker.ReportProgress(percentComplete);
                }
            }

            return result;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            //This is where your programs/methods are executed

            System.ComponentModel.BackgroundWorker worker = sender as System.ComponentModel.BackgroundWorker;

            e.Result = ComputeFibonacci((int)numberBox.Value, worker, e);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Update progress bar based on the amount of work done

            this.progressBar1.Value = e.ProgressPercentage;
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Executed when the Do_Work method is finished

            startButton.Enabled = true;
            stopButton.Enabled = false;

            if (e.Cancelled == true) 
            {
                outputBox.Text = "Cancelled";
            }
            else if (e.Error != null) 
            {
                outputBox.Text = "Error: " + e.Error.Message;
            }
            else 
            {
                outputBox.Text = "Done";
            }
        }
    }
}
