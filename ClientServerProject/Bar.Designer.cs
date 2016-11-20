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
            this.tabBarMenu.Location = new System.Drawing.Point(8, 80);
            this.tabBarMenu.Name = "tabBarMenu";
            this.tabBarMenu.SelectedIndex = 0;
            this.tabBarMenu.Size = new System.Drawing.Size(539, 451);
            this.tabBarMenu.TabIndex = 15;
            // 
            // tabWine
            // 
            this.tabWine.Location = new System.Drawing.Point(4, 44);
            this.tabWine.Name = "tabWine";
            this.tabWine.Padding = new System.Windows.Forms.Padding(3);
            this.tabWine.Size = new System.Drawing.Size(531, 403);
            this.tabWine.TabIndex = 0;
            this.tabWine.Text = "Wine";
            this.tabWine.UseVisualStyleBackColor = true;
            // 
            // tabBeer
            // 
            this.tabBeer.Location = new System.Drawing.Point(4, 44);
            this.tabBeer.Name = "tabBeer";
            this.tabBeer.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeer.Size = new System.Drawing.Size(531, 403);
            this.tabBeer.TabIndex = 1;
            this.tabBeer.Text = "Beer";
            this.tabBeer.UseVisualStyleBackColor = true;
            // 
            // tabCocktail
            // 
            this.tabCocktail.Location = new System.Drawing.Point(4, 44);
            this.tabCocktail.Name = "tabCocktail";
            this.tabCocktail.Padding = new System.Windows.Forms.Padding(3);
            this.tabCocktail.Size = new System.Drawing.Size(531, 403);
            this.tabCocktail.TabIndex = 2;
            this.tabCocktail.Text = "Cocktails";
            this.tabCocktail.UseVisualStyleBackColor = true;
            // 
            // tabJuicePop
            // 
            this.tabJuicePop.Location = new System.Drawing.Point(4, 44);
            this.tabJuicePop.Name = "tabJuicePop";
            this.tabJuicePop.Padding = new System.Windows.Forms.Padding(3);
            this.tabJuicePop.Size = new System.Drawing.Size(531, 403);
            this.tabJuicePop.TabIndex = 3;
            this.tabJuicePop.Text = "Juice & Pop";
            this.tabJuicePop.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(553, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(282, 451);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btnBarB
            // 
            this.btnBarB.Location = new System.Drawing.Point(553, 533);
            this.btnBarB.Name = "btnBarB";
            this.btnBarB.Size = new System.Drawing.Size(110, 38);
            this.btnBarB.TabIndex = 14;
            this.btnBarB.Text = "Back";
            this.btnBarB.UseVisualStyleBackColor = true;
            // 
            // btnBarConfirm
            // 
            this.btnBarConfirm.Location = new System.Drawing.Point(433, 533);
            this.btnBarConfirm.Name = "btnBarConfirm";
            this.btnBarConfirm.Size = new System.Drawing.Size(110, 38);
            this.btnBarConfirm.TabIndex = 13;
            this.btnBarConfirm.Text = "Checkout";
            this.btnBarConfirm.UseVisualStyleBackColor = true;
            // 
            // labBarTitle
            // 
            this.labBarTitle.AutoSize = true;
            this.labBarTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labBarTitle.Location = new System.Drawing.Point(144, 19);
            this.labBarTitle.Name = "labBarTitle";
            this.labBarTitle.Size = new System.Drawing.Size(530, 39);
            this.labBarTitle.TabIndex = 12;
            this.labBarTitle.Text = "Cruise Ship Bar Ordering System";
            // 
            // Bar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabBarMenu);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnBarB);
            this.Controls.Add(this.btnBarConfirm);
            this.Controls.Add(this.labBarTitle);
            this.Name = "Bar";
            this.Size = new System.Drawing.Size(842, 590);
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
    }
}
