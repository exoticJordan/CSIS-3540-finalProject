namespace ClientServerProject
{
    partial class PlanSearchResult
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
            this.btnBook = new System.Windows.Forms.Button();
            this.btnNextResult = new System.Windows.Forms.Button();
            this.btnBackToSearch = new System.Windows.Forms.Button();
            this.btnPrevResult = new System.Windows.Forms.Button();
            this.lblCost = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCruiseName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(295, 335);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(93, 23);
            this.btnBook.TabIndex = 37;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click_1);
            // 
            // btnNextResult
            // 
            this.btnNextResult.Location = new System.Drawing.Point(492, 419);
            this.btnNextResult.Name = "btnNextResult";
            this.btnNextResult.Size = new System.Drawing.Size(93, 23);
            this.btnNextResult.TabIndex = 36;
            this.btnNextResult.Text = "Next";
            this.btnNextResult.UseVisualStyleBackColor = true;
            // 
            // btnBackToSearch
            // 
            this.btnBackToSearch.Location = new System.Drawing.Point(295, 419);
            this.btnBackToSearch.Name = "btnBackToSearch";
            this.btnBackToSearch.Size = new System.Drawing.Size(93, 23);
            this.btnBackToSearch.TabIndex = 35;
            this.btnBackToSearch.Text = "Back to Search";
            this.btnBackToSearch.UseVisualStyleBackColor = true;
            this.btnBackToSearch.Click += new System.EventHandler(this.btnBackToSearch_Click);
            // 
            // btnPrevResult
            // 
            this.btnPrevResult.Location = new System.Drawing.Point(113, 419);
            this.btnPrevResult.Name = "btnPrevResult";
            this.btnPrevResult.Size = new System.Drawing.Size(93, 23);
            this.btnPrevResult.TabIndex = 34;
            this.btnPrevResult.Text = "Previous";
            this.btnPrevResult.UseVisualStyleBackColor = true;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(345, 274);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(28, 13);
            this.lblCost.TabIndex = 33;
            this.lblCost.Text = "1.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "CAD $";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Location = new System.Drawing.Point(279, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 23);
            this.label6.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Location = new System.Drawing.Point(279, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 23);
            this.label5.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(279, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(221, 23);
            this.label4.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Duration";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(188, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ship";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Itinary";
            // 
            // lblCruiseName
            // 
            this.lblCruiseName.Location = new System.Drawing.Point(306, 64);
            this.lblCruiseName.Name = "lblCruiseName";
            this.lblCruiseName.Size = new System.Drawing.Size(67, 25);
            this.lblCruiseName.TabIndex = 25;
            this.lblCruiseName.Text = "Cruise Name";
            // 
            // PlanSearchResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.btnNextResult);
            this.Controls.Add(this.btnBackToSearch);
            this.Controls.Add(this.btnPrevResult);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCruiseName);
            this.Name = "PlanSearchResult";
            this.Size = new System.Drawing.Size(699, 515);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnNextResult;
        private System.Windows.Forms.Button btnBackToSearch;
        private System.Windows.Forms.Button btnPrevResult;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCruiseName;
    }
}
