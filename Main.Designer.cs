namespace ThreadingExample
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundThread = new System.Windows.Forms.Button();
            this.threadPool = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Threading";
            // 
            // backgroundThread
            // 
            this.backgroundThread.Location = new System.Drawing.Point(122, 172);
            this.backgroundThread.Name = "backgroundThread";
            this.backgroundThread.Size = new System.Drawing.Size(119, 52);
            this.backgroundThread.TabIndex = 1;
            this.backgroundThread.Text = "Background Threading";
            this.backgroundThread.UseVisualStyleBackColor = true;
            this.backgroundThread.Click += new System.EventHandler(this.backgroundThread_Click);
            // 
            // threadPool
            // 
            this.threadPool.Location = new System.Drawing.Point(247, 172);
            this.threadPool.Name = "threadPool";
            this.threadPool.Size = new System.Drawing.Size(119, 52);
            this.threadPool.TabIndex = 2;
            this.threadPool.Text = "Thread Pool";
            this.threadPool.UseVisualStyleBackColor = true;
            this.threadPool.Click += new System.EventHandler(this.threadPool_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 52);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(623, 277);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.threadPool);
            this.Controls.Add(this.backgroundThread);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backgroundThread;
        private System.Windows.Forms.Button threadPool;
        private System.Windows.Forms.Button button3;
    }
}