namespace ClientServerProject
{
    partial class Bar
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
            this.tabBarMenu = new System.Windows.Forms.TabControl();
            this.tabWine = new System.Windows.Forms.TabPage();
            this.GVWine = new System.Windows.Forms.DataGridView();
            this.tabBeer = new System.Windows.Forms.TabPage();
            this.GVBeer = new System.Windows.Forms.DataGridView();
            this.tabCocktail = new System.Windows.Forms.TabPage();
            this.GVCocktail = new System.Windows.Forms.DataGridView();
            this.tabJuicePop = new System.Windows.Forms.TabPage();
            this.GVJuice = new System.Windows.Forms.DataGridView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.labBarTitle = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGSCheck = new System.Windows.Forms.Button();
            this.btnBarB = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbShip = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCruise = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRoom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.tabBarMenu.SuspendLayout();
            this.tabWine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVWine)).BeginInit();
            this.tabBeer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVBeer)).BeginInit();
            this.tabCocktail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVCocktail)).BeginInit();
            this.tabJuicePop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GVJuice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabBarMenu
            // 
            this.tabBarMenu.Controls.Add(this.tabWine);
            this.tabBarMenu.Controls.Add(this.tabBeer);
            this.tabBarMenu.Controls.Add(this.tabCocktail);
            this.tabBarMenu.Controls.Add(this.tabJuicePop);
            this.tabBarMenu.ItemSize = new System.Drawing.Size(96, 40);
            this.tabBarMenu.Location = new System.Drawing.Point(3, 77);
            this.tabBarMenu.Name = "tabBarMenu";
            this.tabBarMenu.SelectedIndex = 0;
            this.tabBarMenu.Size = new System.Drawing.Size(286, 227);
            this.tabBarMenu.TabIndex = 15;
            // 
            // tabWine
            // 
            this.tabWine.Controls.Add(this.GVWine);
            this.tabWine.Location = new System.Drawing.Point(4, 44);
            this.tabWine.Name = "tabWine";
            this.tabWine.Padding = new System.Windows.Forms.Padding(3);
            this.tabWine.Size = new System.Drawing.Size(278, 179);
            this.tabWine.TabIndex = 0;
            this.tabWine.Text = "Wine";
            this.tabWine.UseVisualStyleBackColor = true;
            // 
            // GVWine
            // 
            this.GVWine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVWine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVWine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVWine.Location = new System.Drawing.Point(0, 0);
            this.GVWine.Name = "GVWine";
            this.GVWine.Size = new System.Drawing.Size(278, 176);
            this.GVWine.TabIndex = 0;
            this.GVWine.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVWine_CellMouseClick);
            // 
            // tabBeer
            // 
            this.tabBeer.Controls.Add(this.GVBeer);
            this.tabBeer.Location = new System.Drawing.Point(4, 44);
            this.tabBeer.Name = "tabBeer";
            this.tabBeer.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeer.Size = new System.Drawing.Size(278, 179);
            this.tabBeer.TabIndex = 1;
            this.tabBeer.Text = "Beer";
            this.tabBeer.UseVisualStyleBackColor = true;
            // 
            // GVBeer
            // 
            this.GVBeer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVBeer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVBeer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVBeer.Location = new System.Drawing.Point(-3, 0);
            this.GVBeer.Name = "GVBeer";
            this.GVBeer.Size = new System.Drawing.Size(278, 176);
            this.GVBeer.TabIndex = 1;
            this.GVBeer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVBeer_CellMouseClick_1);
            // 
            // tabCocktail
            // 
            this.tabCocktail.Controls.Add(this.GVCocktail);
            this.tabCocktail.Location = new System.Drawing.Point(4, 44);
            this.tabCocktail.Name = "tabCocktail";
            this.tabCocktail.Padding = new System.Windows.Forms.Padding(3);
            this.tabCocktail.Size = new System.Drawing.Size(278, 179);
            this.tabCocktail.TabIndex = 2;
            this.tabCocktail.Text = "Cocktails";
            this.tabCocktail.UseVisualStyleBackColor = true;
            // 
            // GVCocktail
            // 
            this.GVCocktail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVCocktail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVCocktail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCocktail.Location = new System.Drawing.Point(-3, 0);
            this.GVCocktail.Name = "GVCocktail";
            this.GVCocktail.Size = new System.Drawing.Size(278, 176);
            this.GVCocktail.TabIndex = 2;
            this.GVCocktail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVCocktail_CellMouseClick);
            // 
            // tabJuicePop
            // 
            this.tabJuicePop.Controls.Add(this.GVJuice);
            this.tabJuicePop.Location = new System.Drawing.Point(4, 44);
            this.tabJuicePop.Name = "tabJuicePop";
            this.tabJuicePop.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuicePop.Size = new System.Drawing.Size(278, 179);
            this.tabJuicePop.TabIndex = 3;
            this.tabJuicePop.Text = "Juice & Pop";
            this.tabJuicePop.UseVisualStyleBackColor = true;
            // 
            // GVJuice
            // 
            this.GVJuice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GVJuice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GVJuice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVJuice.Location = new System.Drawing.Point(0, 0);
            this.GVJuice.Name = "GVJuice";
            this.GVJuice.Size = new System.Drawing.Size(278, 176);
            this.GVJuice.TabIndex = 1;
            this.GVJuice.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVJuice_CellMouseClick);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(438, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 298);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // labBarTitle
            // 
            this.labBarTitle.AutoSize = true;
            this.labBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarTitle.Location = new System.Drawing.Point(10, 16);
            this.labBarTitle.Name = "labBarTitle";
            this.labBarTitle.Size = new System.Drawing.Size(152, 29);
            this.labBarTitle.TabIndex = 12;
            this.labBarTitle.Text = "Bar Ordering";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(303, 121);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 35);
            this.btnDel.TabIndex = 41;
            this.btnDel.Text = "Delete Item";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGSCheck
            // 
            this.btnGSCheck.Location = new System.Drawing.Point(303, 330);
            this.btnGSCheck.Name = "btnGSCheck";
            this.btnGSCheck.Size = new System.Drawing.Size(110, 35);
            this.btnGSCheck.TabIndex = 39;
            this.btnGSCheck.Text = "Checkout";
            this.btnGSCheck.UseVisualStyleBackColor = true;
            this.btnGSCheck.Click += new System.EventHandler(this.btnGSCheck_Click);
            // 
            // btnBarB
            // 
            this.btnBarB.Location = new System.Drawing.Point(303, 181);
            this.btnBarB.Name = "btnBarB";
            this.btnBarB.Size = new System.Drawing.Size(110, 35);
            this.btnBarB.TabIndex = 14;
            this.btnBarB.Text = "Back";
            this.btnBarB.UseVisualStyleBackColor = true;
            this.btnBarB.Click += new System.EventHandler(this.btnBarB_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.result.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.result.Location = new System.Drawing.Point(566, 313);
            this.result.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(19, 14);
            this.result.TabIndex = 43;
            this.result.Text = "$0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 313);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 42;
            this.label2.Text = "Total：";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(272, 52);
            this.lbID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(17, 12);
            this.lbID.TabIndex = 46;
            this.lbID.Text = "id";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(272, 78);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(29, 12);
            this.lbName.TabIndex = 45;
            this.lbName.Text = "name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 44;
            this.label1.Text = "Staff:";
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
            this.cbShip.Location = new System.Drawing.Point(120, 310);
            this.cbShip.MaxDropDownItems = 5;
            this.cbShip.Name = "cbShip";
            this.cbShip.Size = new System.Drawing.Size(42, 20);
            this.cbShip.TabIndex = 47;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 313);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 48;
            this.label3.Text = "ship_id";
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
            this.cbCruise.Location = new System.Drawing.Point(120, 342);
            this.cbCruise.MaxDropDownItems = 5;
            this.cbCruise.Name = "cbCruise";
            this.cbCruise.Size = new System.Drawing.Size(42, 20);
            this.cbCruise.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 345);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "Cruise_id";
            // 
            // txtRoom
            // 
            this.txtRoom.Location = new System.Drawing.Point(213, 325);
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(52, 21);
            this.txtRoom.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 330);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 52;
            this.label5.Text = "Room";
            // 
            // lbWarning
            // 
            this.lbWarning.AutoSize = true;
            this.lbWarning.Font = new System.Drawing.Font("Elephant", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.Location = new System.Drawing.Point(65, 418);
            this.lbWarning.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(0, 25);
            this.lbWarning.TabIndex = 53;
            // 
            // Bar
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
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnGSCheck);
            this.Controls.Add(this.tabBarMenu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBarB);
            this.Controls.Add(this.labBarTitle);
            this.Name = "Bar";
            this.Size = new System.Drawing.Size(695, 463);
            this.tabBarMenu.ResumeLayout(false);
            this.tabWine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVWine)).EndInit();
            this.tabBeer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVBeer)).EndInit();
            this.tabCocktail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVCocktail)).EndInit();
            this.tabJuicePop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GVJuice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabBarMenu;
        private System.Windows.Forms.TabPage tabWine;
        private System.Windows.Forms.TabPage tabBeer;
        private System.Windows.Forms.TabPage tabCocktail;
        private System.Windows.Forms.TabPage tabJuicePop;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label labBarTitle;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnGSCheck;
        private System.Windows.Forms.Button btnBarB;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GVWine;
        private System.Windows.Forms.DataGridView GVBeer;
        private System.Windows.Forms.DataGridView GVCocktail;
        private System.Windows.Forms.DataGridView GVJuice;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbShip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCruise;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRoom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbWarning;
    }
}
