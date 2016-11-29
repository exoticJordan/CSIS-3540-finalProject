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
            this.result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGSBack = new System.Windows.Forms.Button();
            this.btnGSCheck = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labBarTitle = new System.Windows.Forms.Label();
            this.tabGiftshopMenu = new System.Windows.Forms.TabControl();
            this.tabClothes = new System.Windows.Forms.TabPage();
            this.GVClothes = new System.Windows.Forms.DataGridView();
            this.tabCups = new System.Windows.Forms.TabPage();
            this.GVCups = new System.Windows.Forms.DataGridView();
            this.tabJewelry = new System.Windows.Forms.TabPage();
            this.GVJewelry = new System.Windows.Forms.DataGridView();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.GVBooks = new System.Windows.Forms.DataGridView();
            this.listViewCheck = new System.Windows.Forms.ListView();
            this.btnDel = new System.Windows.Forms.Button();
            this.lbID = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCruise = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbShip = new System.Windows.Forms.ComboBox();
            this.tabGiftshopMenu.SuspendLayout();
            this.tabClothes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVClothes)).BeginInit();
            this.tabCups.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCups)).BeginInit();
            this.tabJewelry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVJewelry)).BeginInit();
            this.tabBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.result.Location = new System.Drawing.Point(547, 372);
            this.result.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(19, 14);
            this.result.TabIndex = 31;
            this.result.Text = "$0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(503, 372);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 30;
            this.label2.Text = "Total：";
            // 
            // btnGSBack
            // 
            this.btnGSBack.Location = new System.Drawing.Point(299, 215);
            this.btnGSBack.Name = "btnGSBack";
            this.btnGSBack.Size = new System.Drawing.Size(110, 35);
            this.btnGSBack.TabIndex = 29;
            this.btnGSBack.Text = "Back";
            this.btnGSBack.UseVisualStyleBackColor = true;
            this.btnGSBack.Click += new System.EventHandler(this.btnGSBack_Click);
            // 
            // btnGSCheck
            // 
            this.btnGSCheck.Location = new System.Drawing.Point(299, 343);
            this.btnGSCheck.Name = "btnGSCheck";
            this.btnGSCheck.Size = new System.Drawing.Size(110, 35);
            this.btnGSCheck.TabIndex = 28;
            this.btnGSCheck.Text = "Checkout";
            this.btnGSCheck.UseVisualStyleBackColor = true;
            this.btnGSCheck.Click += new System.EventHandler(this.btnGSCheck_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(270, 84);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 35;
            this.lbName.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(270, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 34;
            this.label1.Text = "Staff:";
            // 
            // labBarTitle
            // 
            this.labBarTitle.AutoSize = true;
            this.labBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarTitle.Location = new System.Drawing.Point(3, 21);
            this.labBarTitle.Name = "labBarTitle";
            this.labBarTitle.Size = new System.Drawing.Size(151, 29);
            this.labBarTitle.TabIndex = 33;
            this.labBarTitle.Text = "Gift Ordering";
            // 
            // tabGiftshopMenu
            // 
            this.tabGiftshopMenu.Controls.Add(this.tabClothes);
            this.tabGiftshopMenu.Controls.Add(this.tabCups);
            this.tabGiftshopMenu.Controls.Add(this.tabJewelry);
            this.tabGiftshopMenu.Controls.Add(this.tabBooks);
            this.tabGiftshopMenu.ItemSize = new System.Drawing.Size(96, 40);
            this.tabGiftshopMenu.Location = new System.Drawing.Point(7, 97);
            this.tabGiftshopMenu.Name = "tabGiftshopMenu";
            this.tabGiftshopMenu.SelectedIndex = 0;
            this.tabGiftshopMenu.Size = new System.Drawing.Size(286, 227);
            this.tabGiftshopMenu.TabIndex = 36;
            // 
            // tabClothes
            // 
            this.tabClothes.Controls.Add(this.GVClothes);
            this.tabClothes.Location = new System.Drawing.Point(4, 44);
            this.tabClothes.Name = "tabClothes";
            this.tabClothes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClothes.Size = new System.Drawing.Size(278, 179);
            this.tabClothes.TabIndex = 0;
            this.tabClothes.Text = "Clothes";
            this.tabClothes.UseVisualStyleBackColor = true;
            // 
            // GVClothes
            // 
            this.GVClothes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVClothes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVClothes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVClothes.Location = new System.Drawing.Point(2, 2);
            this.GVClothes.Margin = new System.Windows.Forms.Padding(2);
            this.GVClothes.Name = "GVClothes";
            this.GVClothes.RowTemplate.Height = 30;
            this.GVClothes.Size = new System.Drawing.Size(278, 176);
            this.GVClothes.TabIndex = 0;
            this.GVClothes.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVClothes_CellMouseClick);
            // 
            // tabCups
            // 
            this.tabCups.Controls.Add(this.GVCups);
            this.tabCups.Location = new System.Drawing.Point(4, 44);
            this.tabCups.Name = "tabCups";
            this.tabCups.Padding = new System.Windows.Forms.Padding(3);
            this.tabCups.Size = new System.Drawing.Size(278, 179);
            this.tabCups.TabIndex = 1;
            this.tabCups.Text = "Cups";
            this.tabCups.UseVisualStyleBackColor = true;
            // 
            // GVCups
            // 
            this.GVCups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVCups.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVCups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCups.Location = new System.Drawing.Point(2, 2);
            this.GVCups.Margin = new System.Windows.Forms.Padding(2);
            this.GVCups.Name = "GVCups";
            this.GVCups.RowTemplate.Height = 30;
            this.GVCups.Size = new System.Drawing.Size(278, 176);
            this.GVCups.TabIndex = 1;
            this.GVCups.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVCups_CellMouseClick);
            // 
            // tabJewelry
            // 
            this.tabJewelry.Controls.Add(this.GVJewelry);
            this.tabJewelry.Location = new System.Drawing.Point(4, 44);
            this.tabJewelry.Name = "tabJewelry";
            this.tabJewelry.Padding = new System.Windows.Forms.Padding(3);
            this.tabJewelry.Size = new System.Drawing.Size(278, 179);
            this.tabJewelry.TabIndex = 2;
            this.tabJewelry.Text = "Jewelry";
            this.tabJewelry.UseVisualStyleBackColor = true;
            // 
            // GVJewelry
            // 
            this.GVJewelry.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVJewelry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVJewelry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVJewelry.Location = new System.Drawing.Point(-2, 1);
            this.GVJewelry.Margin = new System.Windows.Forms.Padding(2);
            this.GVJewelry.Name = "GVJewelry";
            this.GVJewelry.RowTemplate.Height = 30;
            this.GVJewelry.Size = new System.Drawing.Size(278, 176);
            this.GVJewelry.TabIndex = 1;
            this.GVJewelry.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVJewelry_CellMouseClick);
            // 
            // tabBooks
            // 
            this.tabBooks.Controls.Add(this.GVBooks);
            this.tabBooks.Location = new System.Drawing.Point(4, 44);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(278, 179);
            this.tabBooks.TabIndex = 3;
            this.tabBooks.Text = "Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            // 
            // GVBooks
            // 
            this.GVBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVBooks.Location = new System.Drawing.Point(-2, 2);
            this.GVBooks.Margin = new System.Windows.Forms.Padding(2);
            this.GVBooks.Name = "GVBooks";
            this.GVBooks.RowTemplate.Height = 30;
            this.GVBooks.Size = new System.Drawing.Size(278, 176);
            this.GVBooks.TabIndex = 1;
            this.GVBooks.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVBooks_CellMouseClick);
            // 
            // listViewCheck
            // 
            this.listViewCheck.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.listViewCheck.AllowColumnReorder = true;
            this.listViewCheck.FullRowSelect = true;
            this.listViewCheck.GridLines = true;
            this.listViewCheck.Location = new System.Drawing.Point(424, 23);
            this.listViewCheck.Margin = new System.Windows.Forms.Padding(2);
            this.listViewCheck.Name = "listViewCheck";
            this.listViewCheck.Size = new System.Drawing.Size(245, 343);
            this.listViewCheck.TabIndex = 37;
            this.listViewCheck.UseCompatibleStateImageBehavior = false;
            this.listViewCheck.View = System.Windows.Forms.View.List;
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(299, 156);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 35);
            this.btnDel.TabIndex = 38;
            this.btnDel.Text = "Delete Item";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(270, 57);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(17, 12);
            this.lbID.TabIndex = 39;
            this.lbID.Text = "id";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.Location = new System.Drawing.Point(34, 419);
            this.lbWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 25);
            this.lbWarning.TabIndex = 60;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(148, 350);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 59;
            this.label5.Text = "Room";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(182, 345);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(52, 21);
            this.txtRoom.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 365);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 57;
            this.label4.Text = "Cruise_id";
            // 
            // cbCruise
            // 
            this.cbCruise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCruise.FormattingEnabled = true;
            this.cbCruise.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbCruise.Location = new System.Drawing.Point(89, 362);
            this.cbCruise.MaxDropDownItems = 5;
            this.cbCruise.Name = "cbCruise";
            this.cbCruise.Size = new System.Drawing.Size(42, 20);
            this.cbCruise.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 333);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 55;
            this.label3.Text = "ship_id";
            // 
            // cbShip
            // 
            this.cbShip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbShip.FormattingEnabled = true;
            this.cbShip.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbShip.Location = new System.Drawing.Point(89, 330);
            this.cbShip.MaxDropDownItems = 5;
            this.cbShip.Name = "cbShip";
            this.cbShip.Size = new System.Drawing.Size(42, 20);
            this.cbShip.TabIndex = 54;
            // 
            // GiftShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbWarning);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCruise);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbShip);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.listViewCheck);
            this.Controls.Add(this.tabGiftshopMenu);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labBarTitle);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGSBack);
            this.Controls.Add(this.btnGSCheck);
            this.Name = "GiftShop";
            this.Size = new System.Drawing.Size(679, 455);
            this.tabGiftshopMenu.ResumeLayout(false);
            this.tabClothes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVClothes)).EndInit();
            this.tabCups.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVCups)).EndInit();
            this.tabJewelry.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVJewelry)).EndInit();
            this.tabBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGSBack;
        private System.Windows.Forms.Button btnGSCheck;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labBarTitle;
        private System.Windows.Forms.TabControl tabGiftshopMenu;
        private System.Windows.Forms.TabPage tabClothes;
        private System.Windows.Forms.DataGridView GVClothes;
        private System.Windows.Forms.TabPage tabCups;
        private System.Windows.Forms.DataGridView GVCups;
        private System.Windows.Forms.TabPage tabJewelry;
        private System.Windows.Forms.DataGridView GVJewelry;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.DataGridView GVBooks;
        private System.Windows.Forms.ListView listViewCheck;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCruise;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbShip;
    }
}
