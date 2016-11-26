namespace ClientServerProject
{
    partial class Schedule
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lbS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbShip = new System.Windows.Forms.Label();
            this.btnShowSche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(1493, 894);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(181, 76);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbS
            // 
            this.lbS.AutoSize = true;
            this.lbS.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbS.Location = new System.Drawing.Point(27, 31);
            this.lbS.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbS.Name = "lbS";
            this.lbS.Size = new System.Drawing.Size(411, 63);
            this.lbS.TabIndex = 1;
            this.lbS.Text = "Schedule Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1064, 55);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Staff:";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(1309, 55);
            this.lbName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(90, 32);
            this.lbName.TabIndex = 3;
            this.lbName.Text = "Name";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(1160, 55);
            this.lbID.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(38, 32);
            this.lbID.TabIndex = 4;
            this.lbID.Text = "id";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(40, 136);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(1211, 835);
            this.dataGridView.TabIndex = 5;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBox.Location = new System.Drawing.Point(1317, 315);
            this.comboBox.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(127, 39);
            this.comboBox.TabIndex = 6;
            this.comboBox.Visible = false;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1269, 277);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(194, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Ship ID";
            this.label2.Visible = false;
            // 
            // lbShip
            // 
            this.lbShip.AutoSize = true;
            this.lbShip.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShip.Location = new System.Drawing.Point(752, 31);
            this.lbShip.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbShip.Name = "lbShip";
            this.lbShip.Size = new System.Drawing.Size(0, 63);
            this.lbShip.TabIndex = 8;
            // 
            // btnShowSche
            // 
            this.btnShowSche.Location = new System.Drawing.Point(1315, 456);
            this.btnShowSche.Name = "btnShowSche";
            this.btnShowSche.Size = new System.Drawing.Size(282, 70);
            this.btnShowSche.TabIndex = 9;
            this.btnShowSche.Text = "Check Schedule";
            this.btnShowSche.UseVisualStyleBackColor = true;
            this.btnShowSche.Click += new System.EventHandler(this.btnShowSche_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnShowSche);
            this.Controls.Add(this.lbShip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbS);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(1776, 1087);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lbS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbShip;
        private System.Windows.Forms.Button btnShowSche;
    }
}
