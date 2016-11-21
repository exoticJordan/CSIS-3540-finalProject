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
            this.tabGiftshopMenu = new System.Windows.Forms.TabControl();
            this.tabClothes = new System.Windows.Forms.TabPage();
            this.tabCups = new System.Windows.Forms.TabPage();
            this.tabJewelry = new System.Windows.Forms.TabPage();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGSBack = new System.Windows.Forms.Button();
            this.btnGSCheck = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labBarTitle = new System.Windows.Forms.Label();
            this.tabGiftshopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabGiftshopMenu
            // 
            this.tabGiftshopMenu.Controls.Add(this.tabClothes);
            this.tabGiftshopMenu.Controls.Add(this.tabCups);
            this.tabGiftshopMenu.Controls.Add(this.tabJewelry);
            this.tabGiftshopMenu.Controls.Add(this.tabBooks);
            this.tabGiftshopMenu.ItemSize = new System.Drawing.Size(96, 40);
            this.tabGiftshopMenu.Location = new System.Drawing.Point(11, 137);
            this.tabGiftshopMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tabGiftshopMenu.Name = "tabGiftshopMenu";
            this.tabGiftshopMenu.SelectedIndex = 0;
            this.tabGiftshopMenu.Size = new System.Drawing.Size(705, 593);
            this.tabGiftshopMenu.TabIndex = 32;
            // 
            // tabClothes
            // 
            this.tabClothes.Location = new System.Drawing.Point(4, 44);
            this.tabClothes.Margin = new System.Windows.Forms.Padding(4);
            this.tabClothes.Name = "tabClothes";
            this.tabClothes.Padding = new System.Windows.Forms.Padding(4);
            this.tabClothes.Size = new System.Drawing.Size(697, 545);
            this.tabClothes.TabIndex = 0;
            this.tabClothes.Text = "Clothes";
            this.tabClothes.UseVisualStyleBackColor = true;
            // 
            // tabCups
            // 
            this.tabCups.Location = new System.Drawing.Point(4, 44);
            this.tabCups.Margin = new System.Windows.Forms.Padding(4);
            this.tabCups.Name = "tabCups";
            this.tabCups.Padding = new System.Windows.Forms.Padding(4);
            this.tabCups.Size = new System.Drawing.Size(697, 545);
            this.tabCups.TabIndex = 1;
            this.tabCups.Text = "Cups";
            this.tabCups.UseVisualStyleBackColor = true;
            // 
            // tabJewelry
            // 
            this.tabJewelry.Location = new System.Drawing.Point(4, 44);
            this.tabJewelry.Margin = new System.Windows.Forms.Padding(4);
            this.tabJewelry.Name = "tabJewelry";
            this.tabJewelry.Padding = new System.Windows.Forms.Padding(4);
            this.tabJewelry.Size = new System.Drawing.Size(697, 545);
            this.tabJewelry.TabIndex = 2;
            this.tabJewelry.Text = "Jewelry";
            this.tabJewelry.UseVisualStyleBackColor = true;
            // 
            // tabBooks
            // 
            this.tabBooks.Location = new System.Drawing.Point(4, 44);
            this.tabBooks.Margin = new System.Windows.Forms.Padding(4);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(4);
            this.tabBooks.Size = new System.Drawing.Size(697, 545);
            this.tabBooks.TabIndex = 3;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.result.Location = new System.Drawing.Point(1095, 579);
            this.result.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(64, 20);
            this.result.TabIndex = 31;
            this.result.Text = "Result";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(984, 579);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 18);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total： $";
            // 
            // btnGSBack
            // 
            this.btnGSBack.Location = new System.Drawing.Point(1003, 617);
            this.btnGSBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnGSBack.Name = "btnGSBack";
            this.btnGSBack.Size = new System.Drawing.Size(165, 53);
            this.btnGSBack.TabIndex = 29;
            this.btnGSBack.Text = "Back";
            this.btnGSBack.UseVisualStyleBackColor = true;
            this.btnGSBack.Click += new System.EventHandler(this.btnGSBack_Click);
            // 
            // btnGSCheck
            // 
            this.btnGSCheck.Location = new System.Drawing.Point(736, 617);
            this.btnGSCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnGSCheck.Name = "btnGSCheck";
            this.btnGSCheck.Size = new System.Drawing.Size(165, 53);
            this.btnGSCheck.TabIndex = 28;
            this.btnGSCheck.Text = "Checkout";
            this.btnGSCheck.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(724, 10);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(444, 565);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(483, 70);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 18);
            this.lbName.TabIndex = 35;
            this.lbName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Staff Name:";
            // 
            // labBarTitle
            // 
            this.labBarTitle.AutoSize = true;
            this.labBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarTitle.Location = new System.Drawing.Point(4, 32);
            this.labBarTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBarTitle.Name = "labBarTitle";
            this.labBarTitle.Size = new System.Drawing.Size(223, 40);
            this.labBarTitle.TabIndex = 33;
            this.labBarTitle.Text = "Gift Ordering";
            // 
            // GiftShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labBarTitle);
            this.Controls.Add(this.tabGiftshopMenu);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGSBack);
            this.Controls.Add(this.btnGSCheck);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GiftShop";
            this.Size = new System.Drawing.Size(1230, 760);
            this.tabGiftshopMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabGiftshopMenu;
        private System.Windows.Forms.TabPage tabClothes;
        private System.Windows.Forms.TabPage tabCups;
        private System.Windows.Forms.TabPage tabJewelry;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGSBack;
        private System.Windows.Forms.Button btnGSCheck;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labBarTitle;
    }
}
