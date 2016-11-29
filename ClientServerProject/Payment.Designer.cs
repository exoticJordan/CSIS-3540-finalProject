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
			this.btnNext = new System.Windows.Forms.Button();
			this.labTotalDue = new System.Windows.Forms.Label();
			this.labShipName = new System.Windows.Forms.Label();
			this.labCruiseName = new System.Windows.Forms.Label();
			this.labRoom = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedGoods)).BeginInit();
			this.SuspendLayout();
			// 
			// btnPaymentB
			// 
			this.btnPaymentB.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnPaymentB.Location = new System.Drawing.Point(2, 411);
			this.btnPaymentB.Name = "btnPaymentB";
			this.btnPaymentB.Size = new System.Drawing.Size(75, 32);
			this.btnPaymentB.TabIndex = 5;
			this.btnPaymentB.Text = "Back";
			this.btnPaymentB.UseVisualStyleBackColor = true;
			this.btnPaymentB.Click += new System.EventHandler(this.btnPaymentB_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(39, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(358, 16);
			this.label1.TabIndex = 3;
			this.label1.Text = "Cruise Line On Board Payment System";
			// 
			// dgvPurchasedGoods
			// 
			this.dgvPurchasedGoods.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvPurchasedGoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvPurchasedGoods.Location = new System.Drawing.Point(3, 61);
			this.dgvPurchasedGoods.Name = "dgvPurchasedGoods";
			this.dgvPurchasedGoods.Size = new System.Drawing.Size(692, 344);
			this.dgvPurchasedGoods.TabIndex = 6;
			// 
			// labRoomNum
			// 
			this.labRoomNum.AutoSize = true;
			this.labRoomNum.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labRoomNum.Location = new System.Drawing.Point(3, 28);
			this.labRoomNum.Name = "labRoomNum";
			this.labRoomNum.Size = new System.Drawing.Size(96, 11);
			this.labRoomNum.TabIndex = 7;
			this.labRoomNum.Text = "Room Number: ";
			// 
			// btnNext
			// 
			this.btnNext.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNext.Location = new System.Drawing.Point(589, 411);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(106, 32);
			this.btnNext.TabIndex = 8;
			this.btnNext.Text = "Confirm";
			this.btnNext.UseMnemonic = false;
			this.btnNext.UseVisualStyleBackColor = true;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// labTotalDue
			// 
			this.labTotalDue.AutoSize = true;
			this.labTotalDue.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTotalDue.Location = new System.Drawing.Point(404, 419);
			this.labTotalDue.Name = "labTotalDue";
			this.labTotalDue.Size = new System.Drawing.Size(88, 16);
			this.labTotalDue.TabIndex = 9;
			this.labTotalDue.Text = "Total: $";
			// 
			// labShipName
			// 
			this.labShipName.AutoSize = true;
			this.labShipName.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labShipName.Location = new System.Drawing.Point(301, 28);
			this.labShipName.Name = "labShipName";
			this.labShipName.Size = new System.Drawing.Size(82, 11);
			this.labShipName.TabIndex = 11;
			this.labShipName.Text = "Ship Name: ";
			// 
			// labCruiseName
			// 
			this.labCruiseName.AutoSize = true;
			this.labCruiseName.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labCruiseName.Location = new System.Drawing.Point(301, 47);
			this.labCruiseName.Name = "labCruiseName";
			this.labCruiseName.Size = new System.Drawing.Size(96, 11);
			this.labCruiseName.TabIndex = 12;
			this.labCruiseName.Text = "Cruise Name: ";
			// 
			// labRoom
			// 
			this.labRoom.AutoSize = true;
			this.labRoom.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labRoom.Location = new System.Drawing.Point(3, 43);
			this.labRoom.Name = "labRoom";
			this.labRoom.Size = new System.Drawing.Size(34, 15);
			this.labRoom.TabIndex = 10;
			this.labRoom.Text = "000";
			// 
			// Payment
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labCruiseName);
			this.Controls.Add(this.labShipName);
			this.Controls.Add(this.labRoom);
			this.Controls.Add(this.labTotalDue);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.labRoomNum);
			this.Controls.Add(this.dgvPurchasedGoods);
			this.Controls.Add(this.btnPaymentB);
			this.Controls.Add(this.label1);
			this.Name = "Payment";
			this.Size = new System.Drawing.Size(698, 451);
			((System.ComponentModel.ISupportInitialize)(this.dgvPurchasedGoods)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaymentB;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvPurchasedGoods;
		private System.Windows.Forms.Label labRoomNum;
		private System.Windows.Forms.Button btnNext;
		private System.Windows.Forms.Label labTotalDue;
		private System.Windows.Forms.Label labShipName;
		private System.Windows.Forms.Label labCruiseName;
		private System.Windows.Forms.Label labRoom;
	}
}
