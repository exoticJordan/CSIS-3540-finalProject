namespace ClientServerProject
{
    partial class Payment
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
			this.btnPaymentB = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvPurchasedGoods = new System.Windows.Forms.DataGridView();
			this.labRoomNum = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedGoods)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPaymentB
			// 
			this.btnPaymentB.Location = new System.Drawing.Point(371, 490);
			this.btnPaymentB.Name = "btnPaymentB";
			this.btnPaymentB.Size = new System.Drawing.Size(75, 23);
			this.btnPaymentB.TabIndex = 5;
			this.btnPaymentB.Text = "Back";
			this.btnPaymentB.UseVisualStyleBackColor = true;
			this.btnPaymentB.Click += new System.EventHandler(this.btnPaymentB_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(60, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(322, 23);
			this.label1.TabIndex = 3;
			this.label1.Text = "On Board Payment Tracker";
			// 
			// dgvPurchasedGoods
			// 
			this.dgvPurchasedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPurchasedGoods.Location = new System.Drawing.Point(3, 61);
			this.dgvPurchasedGoods.Name = "dgvPurchasedGoods";
			this.dgvPurchasedGoods.Size = new System.Drawing.Size(445, 423);
			this.dgvPurchasedGoods.TabIndex = 6;
			// 
			// labRoomNum
			// 
			this.labRoomNum.AutoSize = true;
			this.labRoomNum.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labRoomNum.Location = new System.Drawing.Point(217, 35);
			this.labRoomNum.Name = "labRoomNum";
			this.labRoomNum.Size = new System.Drawing.Size(179, 23);
			this.labRoomNum.TabIndex = 7;
			this.labRoomNum.Text = "Room Number: ";
			// 
			// Payment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labRoomNum);
			this.Controls.Add(this.dgvPurchasedGoods);
			this.Controls.Add(this.btnPaymentB);
			this.Controls.Add(this.label1);
			this.Name = "Payment";
			this.Size = new System.Drawing.Size(451, 528);
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedGoods)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaymentB;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvPurchasedGoods;
		private System.Windows.Forms.Label labRoomNum;
	}
}
