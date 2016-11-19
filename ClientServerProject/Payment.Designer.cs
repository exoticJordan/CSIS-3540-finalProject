namespace ClientServerProject
{
    partial class Payment
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
            this.btnPaymentB = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPaymentB
            // 
            this.btnPaymentB.Location = new System.Drawing.Point(329, 486);
            this.btnPaymentB.Name = "btnPaymentB";
            this.btnPaymentB.Size = new System.Drawing.Size(75, 23);
            this.btnPaymentB.TabIndex = 5;
            this.btnPaymentB.Text = "Back";
            this.btnPaymentB.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(35, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(370, 413);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "On Board Payment Tracker";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPaymentB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "Payment";
            this.Size = new System.Drawing.Size(451, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPaymentB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
    }
}
