namespace ClientServerProject
{
    partial class PlanGuestNumber
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
            this.lblRoomNum = new System.Windows.Forms.Label();
            this.btnGuestNumCont = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRoomNum
            // 
            this.lblRoomNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoomNum.Location = new System.Drawing.Point(354, 228);
            this.lblRoomNum.Name = "lblRoomNum";
            this.lblRoomNum.Size = new System.Drawing.Size(24, 20);
            this.lblRoomNum.TabIndex = 9;
            this.lblRoomNum.Text = "1";
            // 
            // btnGuestNumCont
            // 
            this.btnGuestNumCont.Location = new System.Drawing.Point(316, 323);
            this.btnGuestNumCont.Name = "btnGuestNumCont";
            this.btnGuestNumCont.Size = new System.Drawing.Size(75, 23);
            this.btnGuestNumCont.TabIndex = 8;
            this.btnGuestNumCont.Text = "Continue";
            this.btnGuestNumCont.UseVisualStyleBackColor = true;
            this.btnGuestNumCont.Click += new System.EventHandler(this.btnGuestNumCont_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(299, 275);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(313, 229);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Room";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(299, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Number of Guests";
            // 
            // PlanGuestNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblRoomNum);
            this.Controls.Add(this.btnGuestNumCont);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Name = "PlanGuestNumber";
            this.Size = new System.Drawing.Size(699, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRoomNum;
        private System.Windows.Forms.Button btnGuestNumCont;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
