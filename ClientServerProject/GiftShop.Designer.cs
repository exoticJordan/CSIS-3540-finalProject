namespace ClientServerProject
{
    partial class GiftShop
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
            this.btnShopB = new System.Windows.Forms.Button();
            this.btnGiftCheck = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnShopB
            // 
            this.btnShopB.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnShopB.Location = new System.Drawing.Point(703, 575);
            this.btnShopB.Name = "btnShopB";
            this.btnShopB.Size = new System.Drawing.Size(109, 25);
            this.btnShopB.TabIndex = 18;
            this.btnShopB.Text = "Back";
            this.btnShopB.UseVisualStyleBackColor = true;
            // 
            // btnGiftCheck
            // 
            this.btnGiftCheck.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnGiftCheck.Location = new System.Drawing.Point(557, 575);
            this.btnGiftCheck.Name = "btnGiftCheck";
            this.btnGiftCheck.Size = new System.Drawing.Size(109, 25);
            this.btnGiftCheck.TabIndex = 17;
            this.btnGiftCheck.Text = "Checkout";
            this.btnGiftCheck.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Snap ITC", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Welcome to Our Gift Shop";
            // 
            // GiftShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShopB);
            this.Controls.Add(this.btnGiftCheck);
            this.Controls.Add(this.label1);
            this.Name = "GiftShop";
            this.Size = new System.Drawing.Size(815, 603);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShopB;
        private System.Windows.Forms.Button btnGiftCheck;
        private System.Windows.Forms.Label label1;
    }
}
