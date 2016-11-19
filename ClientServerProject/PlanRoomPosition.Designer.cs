namespace ClientServerProject
{
    partial class PlanRoomPosition
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMiddle = new System.Windows.Forms.Button();
            this.btnFront = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(155, 221);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Ship Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMiddle
            // 
            this.btnMiddle.Location = new System.Drawing.Point(324, 221);
            this.btnMiddle.Name = "btnMiddle";
            this.btnMiddle.Size = new System.Drawing.Size(75, 23);
            this.btnMiddle.TabIndex = 1;
            this.btnMiddle.Text = "Ship Middle";
            this.btnMiddle.UseVisualStyleBackColor = true;
            this.btnMiddle.Click += new System.EventHandler(this.btnMiddle_Click);
            // 
            // btnFront
            // 
            this.btnFront.Location = new System.Drawing.Point(473, 221);
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(75, 23);
            this.btnFront.TabIndex = 2;
            this.btnFront.Text = "Ship Front";
            this.btnFront.UseVisualStyleBackColor = true;
            this.btnFront.Click += new System.EventHandler(this.btnFront_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(315, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Room";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(384, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "1";
            // 
            // PlanRoomPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFront);
            this.Controls.Add(this.btnMiddle);
            this.Controls.Add(this.btnBack);
            this.Name = "PlanRoomPosition";
            this.Size = new System.Drawing.Size(699, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMiddle;
        private System.Windows.Forms.Button btnFront;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
