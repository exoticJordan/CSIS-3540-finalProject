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
			this.labPayLoginTitle = new System.Windows.Forms.Label();
			this.btnUserBack = new System.Windows.Forms.Button();
			this.btnUserLog = new System.Windows.Forms.Button();
			this.txtRNum = new System.Windows.Forms.TextBox();
			this.labCreds = new System.Windows.Forms.Label();
			this.erpPayLog = new System.Windows.Forms.ErrorProvider(this.components);
			this.txtSID = new System.Windows.Forms.TextBox();
			this.txtCID = new System.Windows.Forms.TextBox();
			this.dash1 = new System.Windows.Forms.Label();
			this.dash2 = new System.Windows.Forms.Label();
			this.room = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.erpPayLog)).BeginInit();
			this.SuspendLayout();
			// 
			// labPayLoginTitle
			// 
			this.labPayLoginTitle.AutoSize = true;
			this.labPayLoginTitle.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPayLoginTitle.Location = new System.Drawing.Point(41, 16);
			this.labPayLoginTitle.Name = "labPayLoginTitle";
			this.labPayLoginTitle.Size = new System.Drawing.Size(268, 16);
			this.labPayLoginTitle.TabIndex = 0;
			this.labPayLoginTitle.Text = "Cruise Line Payment System";
			// 
			// btnUserBack
			// 
			this.btnUserBack.Location = new System.Drawing.Point(195, 160);
			this.btnUserBack.Name = "btnUserBack";
			this.btnUserBack.Size = new System.Drawing.Size(75, 23);
			this.btnUserBack.TabIndex = 4;
			this.btnUserBack.Text = "Back";
			this.btnUserBack.UseVisualStyleBackColor = true;
			this.btnUserBack.Click += new System.EventHandler(this.btnUserBack_Click);
			// 
			// btnUserLog
			// 
			this.btnUserLog.Location = new System.Drawing.Point(100, 160);
			this.btnUserLog.Name = "btnUserLog";
			this.btnUserLog.Size = new System.Drawing.Size(75, 23);
			this.btnUserLog.TabIndex = 3;
			this.btnUserLog.Text = "Login";
			this.btnUserLog.UseVisualStyleBackColor = true;
			this.btnUserLog.Click += new System.EventHandler(this.btnUserLog_Click);
			// 
			// txtRNum
			// 
			this.txtRNum.Location = new System.Drawing.Point(129, 97);
			this.txtRNum.Name = "txtRNum";
			this.txtRNum.PasswordChar = '*';
			this.txtRNum.Size = new System.Drawing.Size(36, 20);
			this.txtRNum.TabIndex = 0;
			// 
			// labCreds
			// 
			this.labCreds.AutoSize = true;
			this.labCreds.Location = new System.Drawing.Point(70, 100);
			this.labCreds.Name = "labCreds";
			this.labCreds.Size = new System.Drawing.Size(54, 13);
			this.labCreds.TabIndex = 8;
			this.labCreds.Text = "Credential";
			// 
			// erpPayLog
			// 
			this.erpPayLog.ContainerControl = this;
			// 
			// txtSID
			// 
			this.txtSID.Location = new System.Drawing.Point(182, 97);
			this.txtSID.Name = "txtSID";
			this.txtSID.PasswordChar = '*';
			this.txtSID.Size = new System.Drawing.Size(36, 20);
			this.txtSID.TabIndex = 1;
			// 
			// txtCID
			// 
			this.txtCID.Location = new System.Drawing.Point(234, 97);
			this.txtCID.Name = "txtCID";
			this.txtCID.PasswordChar = '*';
			this.txtCID.Size = new System.Drawing.Size(36, 20);
			this.txtCID.TabIndex = 2;
			this.txtCID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCID_KeyDown);
			// 
			// dash1
			// 
			this.dash1.AutoSize = true;
			this.dash1.Location = new System.Drawing.Point(171, 100);
			this.dash1.Name = "dash1";
			this.dash1.Size = new System.Drawing.Size(10, 13);
			this.dash1.TabIndex = 14;
			this.dash1.Text = "-";
			// 
			// dash2
			// 
			this.dash2.AutoSize = true;
			this.dash2.Location = new System.Drawing.Point(224, 100);
			this.dash2.Name = "dash2";
			this.dash2.Size = new System.Drawing.Size(10, 13);
			this.dash2.TabIndex = 15;
			this.dash2.Text = "-";
			// 
			// room
			// 
			this.room.AutoSize = true;
			this.room.Location = new System.Drawing.Point(126, 81);
			this.room.Name = "room";
			this.room.Size = new System.Drawing.Size(45, 13);
			this.room.TabIndex = 16;
			this.room.Text = "Room #";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(180, 81);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 13);
			this.label1.TabIndex = 17;
			this.label1.Text = "Ship #";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(228, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(46, 13);
			this.label2.TabIndex = 18;
			this.label2.Text = "Cruise #";
			// 
			// PaymentLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.room);
			this.Controls.Add(this.dash2);
			this.Controls.Add(this.dash1);
			this.Controls.Add(this.txtCID);
			this.Controls.Add(this.txtSID);
			this.Controls.Add(this.btnUserBack);
			this.Controls.Add(this.btnUserLog);
			this.Controls.Add(this.txtRNum);
			this.Controls.Add(this.labCreds);
			this.Controls.Add(this.labPayLoginTitle);
			this.Name = "PaymentLogin";
			this.Size = new System.Drawing.Size(360, 201);
			((System.ComponentModel.ISupportInitialize)(this.erpPayLog)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labPayLoginTitle;
        private System.Windows.Forms.Button btnUserBack;
        private System.Windows.Forms.Button btnUserLog;
        private System.Windows.Forms.TextBox txtRNum;
        private System.Windows.Forms.Label labCreds;
		private System.Windows.Forms.ErrorProvider erpPayLog;
		private System.Windows.Forms.Label dash2;
		private System.Windows.Forms.Label dash1;
		private System.Windows.Forms.TextBox txtCID;
		private System.Windows.Forms.TextBox txtSID;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label room;
	}
}
