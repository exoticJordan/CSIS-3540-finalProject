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
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnGSCheck = new System.Windows.Forms.Button();
            this.btnBarB = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            this.tabBarMenu.Location = new System.Drawing.Point(3, 83);
            this.tabBarMenu.Name = "tabBarMenu";
            this.tabBarMenu.SelectedIndex = 0;
            this.tabBarMenu.Size = new System.Drawing.Size(285, 173);
            this.tabBarMenu.TabIndex = 15;
            // 
            // tabWine
            // 
            this.tabWine.Controls.Add(this.GVWine);
            this.tabWine.Location = new System.Drawing.Point(4, 44);
            this.tabWine.Name = "tabWine";
            this.tabWine.Padding = new System.Windows.Forms.Padding(3);
            this.tabWine.Size = new System.Drawing.Size(277, 125);
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
            this.GVWine.Size = new System.Drawing.Size(276, 125);
            this.GVWine.TabIndex = 0;
            this.GVWine.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVWine_CellMouseClick);
            // 
            // tabBeer
            // 
            this.tabBeer.Controls.Add(this.GVBeer);
            this.tabBeer.Location = new System.Drawing.Point(4, 44);
            this.tabBeer.Name = "tabBeer";
            this.tabBeer.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeer.Size = new System.Drawing.Size(277, 125);
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
            this.GVBeer.Size = new System.Drawing.Size(280, 140);
            this.GVBeer.TabIndex = 1;
            this.GVBeer.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVBeer_CellMouseClick_1);
            // 
            // tabCocktail
            // 
            this.tabCocktail.Controls.Add(this.GVCocktail);
            this.tabCocktail.Location = new System.Drawing.Point(4, 44);
            this.tabCocktail.Name = "tabCocktail";
            this.tabCocktail.Padding = new System.Windows.Forms.Padding(3);
            this.tabCocktail.Size = new System.Drawing.Size(277, 125);
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
            this.GVCocktail.Size = new System.Drawing.Size(284, 125);
            this.GVCocktail.TabIndex = 2;
            this.GVCocktail.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVCocktail_CellMouseClick);
            // 
            // tabJuicePop
            // 
            this.tabJuicePop.Controls.Add(this.GVJuice);
            this.tabJuicePop.Location = new System.Drawing.Point(4, 44);
            this.tabJuicePop.Name = "tabJuicePop";
            this.tabJuicePop.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuicePop.Size = new System.Drawing.Size(277, 125);
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
            this.GVJuice.Size = new System.Drawing.Size(277, 134);
            this.GVJuice.TabIndex = 1;
            this.GVJuice.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GVJuice_CellMouseClick);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(438, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(243, 322);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // labBarTitle
            // 
            this.labBarTitle.AutoSize = true;
            this.labBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarTitle.Location = new System.Drawing.Point(10, 17);
            this.labBarTitle.Name = "labBarTitle";
            this.labBarTitle.Size = new System.Drawing.Size(152, 29);
            this.labBarTitle.TabIndex = 12;
            this.labBarTitle.Text = "Bar Ordering";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(314, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Staff Name:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(322, 63);
            this.lbName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "label2";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(303, 130);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(110, 38);
            this.btnDel.TabIndex = 41;
            this.btnDel.Text = "Delete Item";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnGSCheck
            // 
            this.btnGSCheck.Location = new System.Drawing.Point(303, 265);
            this.btnGSCheck.Name = "btnGSCheck";
            this.btnGSCheck.Size = new System.Drawing.Size(110, 38);
            this.btnGSCheck.TabIndex = 39;
            this.btnGSCheck.Text = "Checkout";
            this.btnGSCheck.UseVisualStyleBackColor = true;
            // 
            // btnBarB
            // 
            this.btnBarB.Location = new System.Drawing.Point(303, 196);
            this.btnBarB.Name = "btnBarB";
            this.btnBarB.Size = new System.Drawing.Size(110, 38);
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
            this.result.Location = new System.Drawing.Point(566, 339);
            this.result.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(21, 15);
            this.result.TabIndex = 43;
            this.result.Text = "$0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(522, 339);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Total：";
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnGSCheck);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabBarMenu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBarB);
            this.Controls.Add(this.labBarTitle);
            this.Name = "Bar";
            this.Size = new System.Drawing.Size(698, 380);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnGSCheck;
        private System.Windows.Forms.Button btnBarB;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView GVWine;
        private System.Windows.Forms.DataGridView GVBeer;
        private System.Windows.Forms.DataGridView GVCocktail;
        private System.Windows.Forms.DataGridView GVJuice;
    }
}
