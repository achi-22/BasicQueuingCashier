namespace BasicQueuingCashier
{
    partial class QueuingForm
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
            this.lblQueue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttoncashier = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(63, 215);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "*Click to get a number";
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.BackColor = System.Drawing.Color.Transparent;
            this.lblQueue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQueue.ForeColor = System.Drawing.Color.White;
            this.lblQueue.Location = new System.Drawing.Point(267, 116);
            this.lblQueue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(296, 69);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.Text = "P - 10000";
            this.lblQueue.Click += new System.EventHandler(this.lblQueue_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(344, 91);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Position in Queue";
            // 
            // buttoncashier
            // 
            this.buttoncashier.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttoncashier.ForeColor = System.Drawing.Color.Teal;
            this.buttoncashier.Location = new System.Drawing.Point(67, 91);
            this.buttoncashier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttoncashier.Name = "buttoncashier";
            this.buttoncashier.Size = new System.Drawing.Size(144, 92);
            this.buttoncashier.TabIndex = 4;
            this.buttoncashier.Text = "Cashier";
            this.buttoncashier.UseVisualStyleBackColor = false;
            this.buttoncashier.Click += new System.EventHandler(this.buttoncashier_Click);
            // 
            // QueuingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(647, 306);
            this.Controls.Add(this.buttoncashier);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QueuingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QueuingForm";
            this.Load += new System.EventHandler(this.QueuingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

   //     private System.Windows.Forms.Button btnCashier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttoncashier;
    }
}

