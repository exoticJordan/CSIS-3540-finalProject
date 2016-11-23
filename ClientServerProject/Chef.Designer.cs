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
            this.lbName = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnS = new System.Windows.Forms.Button();
            this.btnCSBack = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(175, 119);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Name";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(118, 66);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(88, 37);
            this.lbTitle.TabIndex = 5;
            this.lbTitle.Text = "Chef";
            // 
            // btnS
            // 
            this.btnS.Location = new System.Drawing.Point(153, 178);
            this.btnS.Name = "btnS";
            this.btnS.Size = new System.Drawing.Size(84, 72);
            this.btnS.TabIndex = 4;
            this.btnS.Text = "Schedule";
            this.btnS.UseVisualStyleBackColor = true;
            this.btnS.Click += new System.EventHandler(this.btnS_Click);
            // 
            // btnCSBack
            // 
            this.btnCSBack.Location = new System.Drawing.Point(340, 15);
            this.btnCSBack.Name = "btnCSBack";
            this.btnCSBack.Size = new System.Drawing.Size(75, 23);
            this.btnCSBack.TabIndex = 8;
            this.btnCSBack.Text = "Logout";
            this.btnCSBack.UseVisualStyleBackColor = true;
            this.btnCSBack.Click += new System.EventHandler(this.btnCSBack_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(122, 119);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(15, 13);
            this.lbID.TabIndex = 15;
            this.lbID.Text = "id";
            // 
            // Chef
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnCSBack);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.btnS);
            this.Name = "Chef";
            this.Size = new System.Drawing.Size(476, 328);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnS;
        private System.Windows.Forms.Button btnCSBack;
        private System.Windows.Forms.Label lbID;
    }
}
