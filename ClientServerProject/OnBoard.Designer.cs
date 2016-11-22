namespace ClientServerProject
{
    partial class OnBoard
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
            this.btnEmLog = new System.Windows.Forms.Button();
            this.btnOBBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEmLog
            // 
            this.btnEmLog.Location = new System.Drawing.Point(530, 280);
            this.btnEmLog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmLog.Name = "btnEmLog";
            this.btnEmLog.Size = new System.Drawing.Size(171, 32);
            this.btnEmLog.TabIndex = 0;
            this.btnEmLog.Text = "EmployeeLogin";
            this.btnEmLog.UseVisualStyleBackColor = true;
            this.btnEmLog.Click += new System.EventHandler(this.btnEmLog_Click);
            // 
            // btnOBBack
            // 
            this.btnOBBack.Location = new System.Drawing.Point(573, 320);
            this.btnOBBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOBBack.Name = "btnOBBack";
            this.btnOBBack.Size = new System.Drawing.Size(112, 32);
            this.btnOBBack.TabIndex = 1;
            this.btnOBBack.Text = "Back";
            this.btnOBBack.UseVisualStyleBackColor = true;
            this.btnOBBack.Click += new System.EventHandler(this.btnOBBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Weather";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Date";
            // 
            // OnBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOBBack);
            this.Controls.Add(this.btnEmLog);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "OnBoard";
            this.Size = new System.Drawing.Size(705, 415);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEmLog;
        private System.Windows.Forms.Button btnOBBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
