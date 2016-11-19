namespace ClientServerProject
{
    partial class EMstatus
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
			this.txtChef = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnChefS = new System.Windows.Forms.Button();
			this.btnCSBack = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnBA
			// 
			this.btnBA.Location = new System.Drawing.Point(165, 137);
			this.btnBA.Name = "btnBA";
			this.btnBA.Size = new System.Drawing.Size(90, 40);
			this.btnBA.TabIndex = 7;
			this.btnBA.Text = "Dinning Room Assigned";
			this.btnBA.UseVisualStyleBackColor = true;
			// 
			// txtChef
			// 
			this.txtChef.AutoSize = true;
			this.txtChef.Location = new System.Drawing.Point(114, 86);
			this.txtChef.Name = "txtChef";
			this.txtChef.Size = new System.Drawing.Size(35, 13);
			this.txtChef.TabIndex = 6;
			this.txtChef.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(89, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(88, 37);
			this.label1.TabIndex = 5;
			this.label1.Text = "Chef";
			// 
			// btnChefS
			// 
			this.btnChefS.Location = new System.Drawing.Point(24, 137);
			this.btnChefS.Name = "btnChefS";
			this.btnChefS.Size = new System.Drawing.Size(79, 40);
			this.btnChefS.TabIndex = 4;
			this.btnChefS.Text = "Schedule";
			this.btnChefS.UseVisualStyleBackColor = true;
			// 
			// btnCSBack
			// 
			this.btnCSBack.Location = new System.Drawing.Point(202, 3);
			this.btnCSBack.Name = "btnCSBack";
			this.btnCSBack.Size = new System.Drawing.Size(75, 23);
			this.btnCSBack.TabIndex = 8;
			this.btnCSBack.Text = "Logout";
			this.btnCSBack.UseVisualStyleBackColor = true;
			// 
			// Chef
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnCSBack);
			this.Controls.Add(this.btnBA);
			this.Controls.Add(this.txtChef);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnChefS);
			this.Name = "Chef";
			this.Size = new System.Drawing.Size(280, 195);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBA;
        private System.Windows.Forms.Label txtChef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnChefS;
        private System.Windows.Forms.Button btnCSBack;
    }
}
