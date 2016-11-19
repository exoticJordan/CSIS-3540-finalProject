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
            this.SuspendLayout();
            // 
            // btnEmLog
            // 
            this.btnEmLog.Location = new System.Drawing.Point(343, 185);
            this.btnEmLog.Name = "btnEmLog";
            this.btnEmLog.Size = new System.Drawing.Size(114, 23);
            this.btnEmLog.TabIndex = 0;
            this.btnEmLog.Text = "EmployeeLogin";
            this.btnEmLog.UseVisualStyleBackColor = true;
            this.btnEmLog.Click += new System.EventHandler(this.btnEmLog_Click);
            // 
            // btnOBBack
            // 
            this.btnOBBack.Location = new System.Drawing.Point(382, 231);
            this.btnOBBack.Name = "btnOBBack";
            this.btnOBBack.Size = new System.Drawing.Size(75, 23);
            this.btnOBBack.TabIndex = 1;
            this.btnOBBack.Text = "Back";
            this.btnOBBack.UseVisualStyleBackColor = true;
            this.btnOBBack.Click += new System.EventHandler(this.btnOBBack_Click);
            // 
            // OnBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnOBBack);
            this.Controls.Add(this.btnEmLog);
            this.Name = "OnBoard";
            this.Size = new System.Drawing.Size(470, 300);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEmLog;
        private System.Windows.Forms.Button btnOBBack;
    }
}
