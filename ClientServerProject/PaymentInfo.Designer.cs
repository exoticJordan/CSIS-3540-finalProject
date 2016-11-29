namespace ClientServerProject
{
	partial class PaymentInfo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentInfo));
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPay = new System.Windows.Forms.Button();
			this.labCCV = new System.Windows.Forms.Label();
			this.txtCCV = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtYear = new System.Windows.Forms.TextBox();
			this.labExpDate = new System.Windows.Forms.Label();
			this.labCardNum = new System.Windows.Forms.Label();
			this.labCardName = new System.Windows.Forms.Label();
			this.txtMonth = new System.Windows.Forms.TextBox();
			this.txtCardName = new System.Windows.Forms.TextBox();
			this.txtCardNum = new System.Windows.Forms.TextBox();
			this.imgPlaceholder = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.imgPlaceholder)).BeginInit();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(33, 245);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 31);
			this.btnCancel.TabIndex = 43;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnPay
			// 
			this.btnPay.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPay.Location = new System.Drawing.Point(114, 245);
			this.btnPay.Name = "btnPay";
			this.btnPay.Size = new System.Drawing.Size(136, 31);
			this.btnPay.TabIndex = 42;
			this.btnPay.Text = "Pay";
			this.btnPay.UseVisualStyleBackColor = true;
			this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
			// 
			// labCCV
			// 
			this.labCCV.AutoSize = true;
			this.labCCV.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCCV.Location = new System.Drawing.Point(154, 192);
			this.labCCV.Name = "labCCV";
			this.labCCV.Size = new System.Drawing.Size(96, 11);
			this.labCCV.TabIndex = 41;
			this.labCCV.Text = "Security code";
			// 
			// txtCCV
			// 
			this.txtCCV.Location = new System.Drawing.Point(181, 219);
			this.txtCCV.Name = "txtCCV";
			this.txtCCV.Size = new System.Drawing.Size(69, 20);
			this.txtCCV.TabIndex = 40;
			this.txtCCV.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCCV_KeyDown);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(99, 206);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(19, 11);
			this.label7.TabIndex = 39;
			this.label7.Text = "yy";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(47, 206);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(19, 11);
			this.label6.TabIndex = 38;
			this.label6.Text = "mm";
			// 
			// txtYear
			// 
			this.txtYear.Location = new System.Drawing.Point(86, 219);
			this.txtYear.Name = "txtYear";
			this.txtYear.Size = new System.Drawing.Size(50, 20);
			this.txtYear.TabIndex = 37;
			// 
			// labExpDate
			// 
			this.labExpDate.AutoSize = true;
			this.labExpDate.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labExpDate.Location = new System.Drawing.Point(36, 192);
			this.labExpDate.Name = "labExpDate";
			this.labExpDate.Size = new System.Drawing.Size(82, 11);
			this.labExpDate.TabIndex = 36;
			this.labExpDate.Text = "Expiry date";
			// 
			// labCardNum
			// 
			this.labCardNum.AutoSize = true;
			this.labCardNum.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCardNum.Location = new System.Drawing.Point(36, 114);
			this.labCardNum.Name = "labCardNum";
			this.labCardNum.Size = new System.Drawing.Size(82, 11);
			this.labCardNum.TabIndex = 35;
			this.labCardNum.Text = "Card number";
			// 
			// labCardName
			// 
			this.labCardName.AutoSize = true;
			this.labCardName.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCardName.Location = new System.Drawing.Point(36, 153);
			this.labCardName.Name = "labCardName";
			this.labCardName.Size = new System.Drawing.Size(110, 11);
			this.labCardName.TabIndex = 34;
			this.labCardName.Text = "Cardholder Name";
			// 
			// txtMonth
			// 
			this.txtMonth.Location = new System.Drawing.Point(34, 219);
			this.txtMonth.Name = "txtMonth";
			this.txtMonth.Size = new System.Drawing.Size(50, 20);
			this.txtMonth.TabIndex = 33;
			// 
			// txtCardName
			// 
			this.txtCardName.Location = new System.Drawing.Point(33, 169);
			this.txtCardName.Name = "txtCardName";
			this.txtCardName.Size = new System.Drawing.Size(217, 20);
			this.txtCardName.TabIndex = 32;
			// 
			// txtCardNum
			// 
			this.txtCardNum.Location = new System.Drawing.Point(33, 130);
			this.txtCardNum.Name = "txtCardNum";
			this.txtCardNum.Size = new System.Drawing.Size(151, 20);
			this.txtCardNum.TabIndex = 31;
			// 
			// imgPlaceholder
			// 
			this.imgPlaceholder.Image = ((System.Drawing.Image)(resources.GetObject("imgPlaceholder.Image")));
			this.imgPlaceholder.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgPlaceholder.InitialImage")));
			this.imgPlaceholder.Location = new System.Drawing.Point(33, 11);
			this.imgPlaceholder.Name = "imgPlaceholder";
			this.imgPlaceholder.Size = new System.Drawing.Size(200, 100);
			this.imgPlaceholder.TabIndex = 44;
			this.imgPlaceholder.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(203, 205);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 11);
			this.label1.TabIndex = 45;
			this.label1.Text = "(CCV)";
			// 
			// PaymentInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.imgPlaceholder);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnPay);
			this.Controls.Add(this.labCCV);
			this.Controls.Add(this.txtCCV);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.txtYear);
			this.Controls.Add(this.labExpDate);
			this.Controls.Add(this.labCardNum);
			this.Controls.Add(this.labCardName);
			this.Controls.Add(this.txtMonth);
			this.Controls.Add(this.txtCardName);
			this.Controls.Add(this.txtCardNum);
			this.Name = "PaymentInfo";
			this.Size = new System.Drawing.Size(285, 293);
			((System.ComponentModel.ISupportInitialize)(this.imgPlaceholder)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnPay;
		private System.Windows.Forms.Label labCCV;
		private System.Windows.Forms.TextBox txtCCV;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtYear;
		private System.Windows.Forms.Label labExpDate;
		private System.Windows.Forms.Label labCardNum;
		private System.Windows.Forms.Label labCardName;
		private System.Windows.Forms.TextBox txtMonth;
		private System.Windows.Forms.TextBox txtCardName;
		private System.Windows.Forms.TextBox txtCardNum;
		private System.Windows.Forms.PictureBox imgPlaceholder;
		private System.Windows.Forms.Label label1;
	}
}
