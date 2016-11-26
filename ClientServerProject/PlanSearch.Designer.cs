namespace ClientServerProject
{
    partial class PlanSearch
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
            this.btnDept = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnDuration = new System.Windows.Forms.Button();
            this.btnOnBoard = new System.Windows.Forms.Button();
            this.dGV1 = new System.Windows.Forms.DataGridView();
            this.btnDest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDept
            // 
            this.btnDept.Location = new System.Drawing.Point(113, 59);
            this.btnDept.Name = "btnDept";
            this.btnDept.Size = new System.Drawing.Size(75, 23);
            this.btnDept.TabIndex = 13;
            this.btnDept.Text = "Departure";
            this.btnDept.UseVisualStyleBackColor = true;
            this.btnDept.Click += new System.EventHandler(this.btnDept_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(312, 343);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDate
            // 
            this.btnDate.Location = new System.Drawing.Point(384, 59);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(75, 23);
            this.btnDate.TabIndex = 15;
            this.btnDate.Text = "Date";
            this.btnDate.UseVisualStyleBackColor = true;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnDuration
            // 
            this.btnDuration.Location = new System.Drawing.Point(509, 59);
            this.btnDuration.Name = "btnDuration";
            this.btnDuration.Size = new System.Drawing.Size(75, 23);
            this.btnDuration.TabIndex = 16;
            this.btnDuration.Text = "Duration";
            this.btnDuration.UseVisualStyleBackColor = true;
            this.btnDuration.Click += new System.EventHandler(this.btnDuration_Click);
            // 
            // btnOnBoard
            // 
            this.btnOnBoard.Location = new System.Drawing.Point(260, 403);
            this.btnOnBoard.Name = "btnOnBoard";
            this.btnOnBoard.Size = new System.Drawing.Size(177, 29);
            this.btnOnBoard.TabIndex = 20;
            this.btnOnBoard.Text = "OnBoard Information";
            this.btnOnBoard.UseVisualStyleBackColor = true;
            this.btnOnBoard.Click += new System.EventHandler(this.btnOnBoard_Click);
            // 
            // dGV1
            // 
            this.dGV1.AllowUserToAddRows = false;
            this.dGV1.AllowUserToDeleteRows = false;
            this.dGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGV1.Location = new System.Drawing.Point(113, 135);
            this.dGV1.MultiSelect = false;
            this.dGV1.Name = "dGV1";
            this.dGV1.ReadOnly = true;
            this.dGV1.Size = new System.Drawing.Size(471, 155);
            this.dGV1.TabIndex = 21;
            this.dGV1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dGV1_CellContentClick);
            // 
            // btnDest
            // 
            this.btnDest.Location = new System.Drawing.Point(248, 59);
            this.btnDest.Name = "btnDest";
            this.btnDest.Size = new System.Drawing.Size(75, 23);
            this.btnDest.TabIndex = 22;
            this.btnDest.Text = "Destination";
            this.btnDest.UseVisualStyleBackColor = true;
            this.btnDest.Click += new System.EventHandler(this.btnDest_Click);
            // 
            // PlanSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnDest);
            this.Controls.Add(this.dGV1);
            this.Controls.Add(this.btnOnBoard);
            this.Controls.Add(this.btnDept);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDate);
            this.Controls.Add(this.btnDuration);
            this.Name = "PlanSearch";
            this.Size = new System.Drawing.Size(699, 515);
            this.Load += new System.EventHandler(this.PlanSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGV1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnDept;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDate;
        private System.Windows.Forms.Button btnDuration;
        private System.Windows.Forms.Button btnOnBoard;
        private System.Windows.Forms.DataGridView dGV1;
        private System.Windows.Forms.Button btnDest;
    }
}
