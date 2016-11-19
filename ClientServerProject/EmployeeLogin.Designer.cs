namespace ClientServerProject
{
    partial class EmployeeLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmId = new System.Windows.Forms.TextBox();
            this.txtEmPW = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEmLog = new System.Windows.Forms.Button();
            this.btnEmBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Id";
            // 
            // txtEmId
            // 
            this.txtEmId.Location = new System.Drawing.Point(117, 21);
            this.txtEmId.Name = "txtEmId";
            this.txtEmId.Size = new System.Drawing.Size(141, 20);
            this.txtEmId.TabIndex = 1;
            // 
            // txtEmPW
            // 
            this.txtEmPW.Location = new System.Drawing.Point(117, 64);
            this.txtEmPW.Name = "txtEmPW";
            this.txtEmPW.Size = new System.Drawing.Size(141, 20);
            this.txtEmPW.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password";
            // 
            // btnEmLog
            // 
            this.btnEmLog.Location = new System.Drawing.Point(72, 120);
            this.btnEmLog.Name = "btnEmLog";
            this.btnEmLog.Size = new System.Drawing.Size(75, 23);
            this.btnEmLog.TabIndex = 4;
            this.btnEmLog.Text = "Login";
            this.btnEmLog.UseVisualStyleBackColor = true;
            // 
            // btnEmBack
            // 
            this.btnEmBack.Location = new System.Drawing.Point(167, 120);
            this.btnEmBack.Name = "btnEmBack";
            this.btnEmBack.Size = new System.Drawing.Size(75, 23);
            this.btnEmBack.TabIndex = 5;
            this.btnEmBack.Text = "Back";
            this.btnEmBack.UseVisualStyleBackColor = true;
            this.btnEmBack.Click += new System.EventHandler(this.btnEmBack_Click);
            // 
            // EmployeeLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEmBack);
            this.Controls.Add(this.btnEmLog);
            this.Controls.Add(this.txtEmPW);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmId);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeLogin";
            this.Size = new System.Drawing.Size(316, 187);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmId;
        private System.Windows.Forms.TextBox txtEmPW;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEmLog;
        private System.Windows.Forms.Button btnEmBack;
    }
}
