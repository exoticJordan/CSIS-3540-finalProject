namespace ClientServerProject
{
    partial class Bartender
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
            this.btnBSBack = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnS = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBSBack
            // 
            this.btnBSBack.Location = new System.Drawing.Point(359, 16);
            this.btnBSBack.Name = "btnBSBack";
            this.btnBSBack.Size = new System.Drawing.Size(75, 23);
            this.btnBSBack.TabIndex = 13;
            this.btnBSBack.Text = "Logout";
            this.btnBSBack.UseVisualStyleBackColor = true;
            this.btnBSBack.Click += new System.EventHandler(this.btnBSBack_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(238, 205);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(90, 82);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(183, 147);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(69, 88);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(166, 37);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Bartender";
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(95, 205);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(95, 82);
            this.btnS.TabIndex = 9;
            this.btnS.Text = "Schedule";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(128, 147);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(15, 13);
            this.lbID.TabIndex = 14;
            this.lbID.Text = "id";
            // 
            // Bartender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnBSBack);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnS);
            this.Name = "Bartender";
            this.Size = new System.Drawing.Size(473, 324);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBSBack;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Label lbID;
    }
}
