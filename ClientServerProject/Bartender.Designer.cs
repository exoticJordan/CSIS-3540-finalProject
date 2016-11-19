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
            this.btnBarOrder = new System.Windows.Forms.Button();
            this.txtBar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBarS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBSBack
            // 
            this.btnBSBack.Location = new System.Drawing.Point(192, 3);
            this.btnBSBack.Name = "btnBSBack";
            this.btnBSBack.Size = new System.Drawing.Size(75, 23);
            this.btnBSBack.TabIndex = 13;
            this.btnBSBack.Text = "Logout";
            this.btnBSBack.UseVisualStyleBackColor = true;
            this.btnBSBack.Click += new System.EventHandler(this.btnBSBack_Click);
            // 
            // btnBarOrder
            // 
            this.btnBarOrder.Location = new System.Drawing.Point(154, 158);
            this.btnBarOrder.Name = "btnBarOrder";
            this.btnBarOrder.Size = new System.Drawing.Size(90, 40);
            this.btnBarOrder.TabIndex = 12;
            this.btnBarOrder.Text = "Order";
            this.btnBarOrder.UseVisualStyleBackColor = true;
            // 
            // txtBar
            // 
            this.txtBar.AutoSize = true;
            this.txtBar.Location = new System.Drawing.Point(113, 111);
            this.txtBar.Name = "txtBar";
            this.txtBar.Size = new System.Drawing.Size(35, 13);
            this.txtBar.TabIndex = 11;
            this.txtBar.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "Bartender";
            // 
            // btnBarS
            // 
            this.btnBarS.Location = new System.Drawing.Point(11, 158);
            this.btnBarS.Name = "btnBarS";
            this.btnBarS.Size = new System.Drawing.Size(79, 40);
            this.btnBarS.TabIndex = 9;
            this.btnBarS.Text = "Schedule";
            this.btnBarS.UseVisualStyleBackColor = true;
            // 
            // Bartender
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBSBack);
            this.Controls.Add(this.btnBarOrder);
            this.Controls.Add(this.txtBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBarS);
            this.Name = "Bartender";
            this.Size = new System.Drawing.Size(282, 223);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBSBack;
        private System.Windows.Forms.Button btnBarOrder;
        private System.Windows.Forms.Label txtBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBarS;
    }
}
