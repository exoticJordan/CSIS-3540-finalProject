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
            this.SuspendLayout();
            // 
            // btnBSBack
            // 
            this.btnBSBack.Location = new System.Drawing.Point(539, 22);
            this.btnBSBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBSBack.Name = "btnBSBack";
            this.btnBSBack.Size = new System.Drawing.Size(112, 32);
            this.btnBSBack.TabIndex = 13;
            this.btnBSBack.Text = "Logout";
            this.btnBSBack.UseVisualStyleBackColor = true;
            this.btnBSBack.Click += new System.EventHandler(this.btnBSBack_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(357, 284);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 114);
            this.btnOrder.TabIndex = 12;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(274, 204);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 18);
            this.lbName.TabIndex = 11;
            this.lbName.Text = "Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(103, 122);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(245, 55);
            this.lbTitle.TabIndex = 10;
            this.lbTitle.Text = "Bartender";
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(142, 284);
            this.btnS.Margin = new System.Windows.Forms.Padding(4);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(143, 114);
            this.btnS.TabIndex = 9;
            this.btnS.Text = "Schedule";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // Bartender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBSBack);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Bartender";
            this.Size = new System.Drawing.Size(710, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBSBack;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnS;
    }
}
