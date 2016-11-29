namespace ClientServerProject
{
    partial class PaymentLogin
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
			this.label1 = new System.Windows.Forms.Label();
			this.btnUserBack = new System.Windows.Forms.Button();
			this.btnUserLog = new System.Windows.Forms.Button();
			this.txtUserPassword = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtRoomNum = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.erpPayLog = new System.Windows.Forms.ErrorProvider(this.components);
			this.labHint1 = new System.Windows.Forms.Label();
			this.labHint2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.erpPayLog)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(49, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(273, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Please Enter Your Room Number and Password";
			// 
			// btnUserBack
			// 
			this.btnUserBack.Location = new System.Drawing.Point(195, 160);
			this.btnUserBack.Name = "btnUserBack";
			this.btnUserBack.Size = new System.Drawing.Size(75, 23);
			this.btnUserBack.TabIndex = 11;
			this.btnUserBack.Text = "Back";
			this.btnUserBack.UseVisualStyleBackColor = true;
			this.btnUserBack.Click += new System.EventHandler(this.btnUserBack_Click);
			// 
			// btnUserLog
			// 
			this.btnUserLog.Location = new System.Drawing.Point(100, 160);
			this.btnUserLog.Name = "btnUserLog";
			this.btnUserLog.Size = new System.Drawing.Size(75, 23);
			this.btnUserLog.TabIndex = 10;
			this.btnUserLog.Text = "Login";
			this.btnUserLog.UseVisualStyleBackColor = true;
			this.btnUserLog.Click += new System.EventHandler(this.btnUserLog_Click);
			// 
			// txtUserPassword
			// 
			this.txtUserPassword.Location = new System.Drawing.Point(129, 74);
			this.txtUserPassword.Name = "txtUserPassword";
			this.txtUserPassword.PasswordChar = '*';
			this.txtUserPassword.Size = new System.Drawing.Size(141, 20);
			this.txtUserPassword.TabIndex = 9;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(70, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 13);
			this.label2.TabIndex = 8;
			this.label2.Text = "Password";
			// 
			// txtRoomNum
			// 
			this.txtRoomNum.Location = new System.Drawing.Point(129, 31);
			this.txtRoomNum.Name = "txtRoomNum";
			this.txtRoomNum.Size = new System.Drawing.Size(141, 20);
			this.txtRoomNum.TabIndex = 7;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(50, 34);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "RoomNumber";
			// 
			// erpPayLog
			// 
			this.erpPayLog.ContainerControl = this;
			// 
			// labHint1
			// 
			this.labHint1.AutoSize = true;
			this.labHint1.Location = new System.Drawing.Point(112, 109);
			this.labHint1.Name = "labHint1";
			this.labHint1.Size = new System.Drawing.Size(158, 13);
			this.labHint1.TabIndex = 12;
			this.labHint1.Text = "Format: Room#-ShipID-CruiseID";
			// 
			// labHint2
			// 
			this.labHint2.AutoSize = true;
			this.labHint2.Location = new System.Drawing.Point(104, 122);
			this.labHint2.Name = "labHint2";
			this.labHint2.Size = new System.Drawing.Size(101, 13);
			this.labHint2.TabIndex = 13;
			this.labHint2.Text = "Example: 101-01-02";
			// 
			// PaymentLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labHint2);
			this.Controls.Add(this.labHint1);
			this.Controls.Add(this.btnUserBack);
			this.Controls.Add(this.btnUserLog);
			this.Controls.Add(this.txtUserPassword);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtRoomNum);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "PaymentLogin";
			this.Size = new System.Drawing.Size(360, 201);
			((System.ComponentModel.ISupportInitialize)(this.erpPayLog)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUserBack;
        private System.Windows.Forms.Button btnUserLog;
        private System.Windows.Forms.TextBox txtUserPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRoomNum;
        private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ErrorProvider erpPayLog;
		private System.Windows.Forms.Label labHint1;
		private System.Windows.Forms.Label labHint2;
	}
}
