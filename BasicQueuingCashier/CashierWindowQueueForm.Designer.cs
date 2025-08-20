namespace BasicQueuingCashier
{
    partial class CashierWindowQueueForm
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
            this.components = new System.ComponentModel.Container();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.listCashierQueue = new System.Windows.Forms.ListView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnRefresh.ForeColor = System.Drawing.Color.Teal;
            this.btnRefresh.Location = new System.Drawing.Point(12, 10);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(96, 49);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnNext.ForeColor = System.Drawing.Color.Teal;
            this.btnNext.Location = new System.Drawing.Point(12, 65);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(96, 49);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // listCashierQueue
            // 
            this.listCashierQueue.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listCashierQueue.ForeColor = System.Drawing.Color.Teal;
            this.listCashierQueue.HideSelection = false;
            this.listCashierQueue.Location = new System.Drawing.Point(125, 10);
            this.listCashierQueue.Name = "listCashierQueue";
            this.listCashierQueue.Size = new System.Drawing.Size(236, 235);
            this.listCashierQueue.TabIndex = 4;
            this.listCashierQueue.UseCompatibleStateImageBehavior = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CashierWindowQueueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(373, 257);
            this.Controls.Add(this.listCashierQueue);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnRefresh);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CashierWindowQueueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CashierWindowQueueForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.ListView listCashierQueue;
        private System.Windows.Forms.Timer timer1;
    }
}