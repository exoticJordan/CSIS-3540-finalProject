namespace ClientServerProject
{
    partial class PlanRoomInformation
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
            this.btnBalcony = new System.Windows.Forms.Button();
            this.btnOcean = new System.Windows.Forms.Button();
            this.btnInside = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblRoomNum3 = new System.Windows.Forms.Label();
            this.lbllbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBalcony
            // 
            this.btnBalcony.Location = new System.Drawing.Point(354, 364);
            this.btnBalcony.Name = "btnBalcony";
            this.btnBalcony.Size = new System.Drawing.Size(75, 23);
            this.btnBalcony.TabIndex = 15;
            this.btnBalcony.Text = "$1";
            this.btnBalcony.UseVisualStyleBackColor = true;
            this.btnBalcony.Click += new System.EventHandler(this.btnBalcony_Click);
            // 
            // btnOcean
            // 
            this.btnOcean.Location = new System.Drawing.Point(354, 294);
            this.btnOcean.Name = "btnOcean";
            this.btnOcean.Size = new System.Drawing.Size(75, 23);
            this.btnOcean.TabIndex = 14;
            this.btnOcean.Text = "$1";
            this.btnOcean.UseVisualStyleBackColor = true;
            this.btnOcean.Click += new System.EventHandler(this.btnOcean_Click);
            // 
            // btnInside
            // 
            this.btnInside.Location = new System.Drawing.Point(355, 224);
            this.btnInside.Name = "btnInside";
            this.btnInside.Size = new System.Drawing.Size(75, 23);
            this.btnInside.TabIndex = 13;
            this.btnInside.Text = "$1";
            this.btnInside.UseVisualStyleBackColor = true;
            this.btnInside.Click += new System.EventHandler(this.btnInside_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(268, 369);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 12;
            this.label20.Text = "Balcony";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(268, 299);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 11;
            this.label19.Text = "Ocean";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(268, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 13);
            this.label18.TabIndex = 10;
            this.label18.Text = "Inside";
            // 
            // lblRoomNum3
            // 
            this.lblRoomNum3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoomNum3.Location = new System.Drawing.Point(348, 128);
            this.lblRoomNum3.Name = "lblRoomNum3";
            this.lblRoomNum3.Size = new System.Drawing.Size(38, 23);
            this.lblRoomNum3.TabIndex = 9;
            this.lblRoomNum3.Text = "1";
            // 
            // lbllbl
            // 
            this.lbllbl.AutoSize = true;
            this.lbllbl.Location = new System.Drawing.Point(307, 129);
            this.lbllbl.Name = "lbllbl";
            this.lbllbl.Size = new System.Drawing.Size(35, 13);
            this.lbllbl.TabIndex = 8;
            this.lbllbl.Text = "Room";
            // 
            // PlanRoomInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBalcony);
            this.Controls.Add(this.btnOcean);
            this.Controls.Add(this.btnInside);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.lblRoomNum3);
            this.Controls.Add(this.lbllbl);
            this.Name = "PlanRoomInformation";
            this.Size = new System.Drawing.Size(699, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBalcony;
        private System.Windows.Forms.Button btnOcean;
        private System.Windows.Forms.Button btnInside;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblRoomNum3;
        private System.Windows.Forms.Label lbllbl;
    }
}
