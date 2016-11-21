namespace ClientServerProject
{
    partial class Chef
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
            this.btnBA = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnS = new System.Windows.Forms.Button();
            this.btnCSBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBA
            // 
            this.btnBA.Location = new System.Drawing.Point(417, 291);
            this.btnBA.Margin = new System.Windows.Forms.Padding(4);
            this.btnBA.Name = "btnBA";
            this.btnBA.Size = new System.Drawing.Size(135, 55);
            this.btnBA.TabIndex = 7;
            this.btnBA.Text = "Dinning Room Assigned";
            this.btnBA.UseVisualStyleBackColor = true;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(263, 165);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(44, 18);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(177, 91);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(130, 55);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Chef";
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(124, 291);
            this.btnS.Margin = new System.Windows.Forms.Padding(4);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(118, 55);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "Schedule";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnCSBack
            // 
            this.btnCSBack.Location = new System.Drawing.Point(510, 21);
            this.btnCSBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnCSBack.Name = "btnCSBack";
            this.btnCSBack.Size = new System.Drawing.Size(112, 32);
            this.btnCSBack.TabIndex = 8;
            this.btnCSBack.Text = "Logout";
            this.btnCSBack.UseVisualStyleBackColor = true;
            this.btnCSBack.Click += new System.EventHandler(this.btnCSBack_Click);
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCSBack);
            this.Controls.Add(this.btnBA);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnS);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Chef";
            this.Size = new System.Drawing.Size(714, 454);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnCSBack;
    }
}
