namespace ClientServerProject
{
    partial class OnBoard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			this.btnEmLog = new System.Windows.Forms.Button();
			this.btnOBBack = new System.Windows.Forms.Button();
			this.lbTime = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.btnPayment = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnEmLog
			// 
			this.btnEmLog.Location = new System.Drawing.Point(344, 14);
			this.btnEmLog.Name = "btnEmLog";
			this.btnEmLog.Size = new System.Drawing.Size(114, 23);
			this.btnEmLog.TabIndex = 0;
			this.btnEmLog.Text = "Employee Login";
			this.btnEmLog.UseVisualStyleBackColor = true;
			this.btnEmLog.Click += new System.EventHandler(this.btnEmLog_Click);
			// 
			// btnOBBack
			// 
			this.btnOBBack.Location = new System.Drawing.Point(13, 264);
			this.btnOBBack.Name = "btnOBBack";
			this.btnOBBack.Size = new System.Drawing.Size(75, 23);
			this.btnOBBack.TabIndex = 1;
			this.btnOBBack.Text = "Back";
			this.btnOBBack.UseVisualStyleBackColor = true;
			this.btnOBBack.Click += new System.EventHandler(this.btnOBBack_Click);
			// 
			// lbTime
			// 
			this.lbTime.AutoSize = true;
			this.lbTime.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTime.Location = new System.Drawing.Point(35, 14);
			this.lbTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.lbTime.Name = "lbTime";
			this.lbTime.Size = new System.Drawing.Size(0, 30);
			this.lbTime.TabIndex = 3;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 500;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// btnPayment
			// 
			this.btnPayment.Location = new System.Drawing.Point(344, 43);
			this.btnPayment.Name = "btnPayment";
			this.btnPayment.Size = new System.Drawing.Size(114, 23);
			this.btnPayment.TabIndex = 4;
			this.btnPayment.Text = "Payment Login";
			this.btnPayment.UseVisualStyleBackColor = true;
			this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
			// 
			// OnBoard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnPayment);
			this.Controls.Add(this.lbTime);
			this.Controls.Add(this.btnOBBack);
			this.Controls.Add(this.btnEmLog);
			this.Name = "OnBoard";
			this.Size = new System.Drawing.Size(470, 300);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmLog;
        private System.Windows.Forms.Button btnOBBack;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Button btnPayment;
	}
}
