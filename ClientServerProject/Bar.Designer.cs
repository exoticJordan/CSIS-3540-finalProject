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
            this.tabBeer = new System.Windows.Forms.TabPage();
            this.tabCocktail = new System.Windows.Forms.TabPage();
            this.tabJuicePop = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnBarB = new System.Windows.Forms.Button();
            this.btnBarConfirm = new System.Windows.Forms.Button();
            this.labBarTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tabBarMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabBarMenu
            // 
            this.tabBarMenu.Controls.Add(this.tabWine);
            this.tabBarMenu.Controls.Add(this.tabBeer);
            this.tabBarMenu.Controls.Add(this.tabCocktail);
            this.tabBarMenu.Controls.Add(this.tabJuicePop);
            this.tabBarMenu.ItemSize = new System.Drawing.Size(96, 40);
            this.tabBarMenu.Location = new System.Drawing.Point(4, 115);
            this.tabBarMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBarMenu.Name = "tabBarMenu";
            this.tabBarMenu.SelectedIndex = 0;
            this.tabBarMenu.Size = new System.Drawing.Size(808, 624);
            this.tabBarMenu.TabIndex = 15;
            // 
            // tabWine
            // 
            this.tabWine.Location = new System.Drawing.Point(4, 44);
            this.tabWine.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabWine.Name = "tabWine";
            this.tabWine.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabWine.Size = new System.Drawing.Size(800, 576);
            this.tabWine.TabIndex = 0;
            this.tabWine.Text = "Wine";
            this.tabWine.UseVisualStyleBackColor = true;
            // 
            // tabBeer
            // 
            this.tabBeer.Location = new System.Drawing.Point(4, 44);
            this.tabBeer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBeer.Name = "tabBeer";
            this.tabBeer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabBeer.Size = new System.Drawing.Size(800, 576);
            this.tabBeer.TabIndex = 1;
            this.tabBeer.Text = "Beer";
            this.tabBeer.UseVisualStyleBackColor = true;
            // 
            // tabCocktail
            // 
            this.tabCocktail.Location = new System.Drawing.Point(4, 44);
            this.tabCocktail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCocktail.Name = "tabCocktail";
            this.tabCocktail.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabCocktail.Size = new System.Drawing.Size(800, 576);
            this.tabCocktail.TabIndex = 2;
            this.tabCocktail.Text = "Cocktails";
            this.tabCocktail.UseVisualStyleBackColor = true;
            // 
            // tabJuicePop
            // 
            this.tabJuicePop.Location = new System.Drawing.Point(4, 44);
            this.tabJuicePop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabJuicePop.Name = "tabJuicePop";
            this.tabJuicePop.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabJuicePop.Size = new System.Drawing.Size(800, 576);
            this.tabJuicePop.TabIndex = 3;
            this.tabJuicePop.Text = "Juice & Pop";
            this.tabJuicePop.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(840, 14);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(421, 623);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnBarB
            // 
            this.btnBarB.Location = new System.Drawing.Point(1073, 659);
            this.btnBarB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBarB.Name = "btnBarB";
            this.btnBarB.Size = new System.Drawing.Size(165, 53);
            this.btnBarB.TabIndex = 14;
            this.btnBarB.Text = "Back";
            this.btnBarB.UseVisualStyleBackColor = true;
            this.btnBarB.Click += new System.EventHandler(this.btnBarB_Click);
            // 
            // btnBarConfirm
            // 
            this.btnBarConfirm.Location = new System.Drawing.Point(852, 659);
            this.btnBarConfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBarConfirm.Name = "btnBarConfirm";
            this.btnBarConfirm.Size = new System.Drawing.Size(165, 53);
            this.btnBarConfirm.TabIndex = 13;
            this.btnBarConfirm.Text = "Checkout";
            this.btnBarConfirm.UseVisualStyleBackColor = true;
            // 
            // labBarTitle
            // 
            this.labBarTitle.AutoSize = true;
            this.labBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarTitle.Location = new System.Drawing.Point(15, 24);
            this.labBarTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labBarTitle.Name = "labBarTitle";
            this.labBarTitle.Size = new System.Drawing.Size(223, 40);
            this.labBarTitle.TabIndex = 12;
            this.labBarTitle.Text = "Bar Ordering";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(575, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Staff Name:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(586, 67);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(62, 18);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "label2";
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tabBarMenu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBarB);
            this.Controls.Add(this.btnBarConfirm);
            this.Controls.Add(this.labBarTitle);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Bar";
            this.Size = new System.Drawing.Size(1291, 758);
            this.tabBarMenu.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnBarB;
        private System.Windows.Forms.Button btnBarConfirm;
        private System.Windows.Forms.Label labBarTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
    }
}
