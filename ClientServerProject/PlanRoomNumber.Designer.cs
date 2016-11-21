namespace ClientServerProject
{
    partial class PlanRoomNumber
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
            this.btnRoomNumCont = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbRoomType = new System.Windows.Forms.ComboBox();
            this.cbGuest = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPosition = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDeck = new System.Windows.Forms.ComboBox();
            this.cbRoomNum = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelGuestNum = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRoomNumCont
            // 
            this.btnRoomNumCont.Location = new System.Drawing.Point(549, 451);
            this.btnRoomNumCont.Name = "btnRoomNumCont";
            this.btnRoomNumCont.Size = new System.Drawing.Size(75, 23);
            this.btnRoomNumCont.TabIndex = 5;
            this.btnRoomNumCont.Text = "Continue";
            this.btnRoomNumCont.UseVisualStyleBackColor = true;
            this.btnRoomNumCont.Click += new System.EventHandler(this.btnRoomNumCont_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Choose Room Type";
            // 
            // cbRoomType
            // 
            this.cbRoomType.FormattingEnabled = true;
            this.cbRoomType.Items.AddRange(new object[] {
            "Inside",
            "Ocean View",
            "Balcony"});
            this.cbRoomType.Location = new System.Drawing.Point(170, 42);
            this.cbRoomType.Name = "cbRoomType";
            this.cbRoomType.Size = new System.Drawing.Size(121, 21);
            this.cbRoomType.TabIndex = 6;
            this.cbRoomType.SelectedIndexChanged += new System.EventHandler(this.cbRoomType_SelectedIndexChanged);
            // 
            // cbGuest
            // 
            this.cbGuest.FormattingEnabled = true;
            this.cbGuest.Location = new System.Drawing.Point(170, 315);
            this.cbGuest.Name = "cbGuest";
            this.cbGuest.Size = new System.Drawing.Size(121, 21);
            this.cbGuest.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number Of Guest";
            // 
            // cbPosition
            // 
            this.cbPosition.FormattingEnabled = true;
            this.cbPosition.Items.AddRange(new object[] {
            "Front",
            "Middle",
            "Back"});
            this.cbPosition.Location = new System.Drawing.Point(170, 108);
            this.cbPosition.Name = "cbPosition";
            this.cbPosition.Size = new System.Drawing.Size(121, 21);
            this.cbPosition.TabIndex = 9;
            this.cbPosition.SelectedIndexChanged += new System.EventHandler(this.cbPosition_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Choose position";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Choose Deck";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Choose Room Num";
            // 
            // cbDeck
            // 
            this.cbDeck.FormattingEnabled = true;
            this.cbDeck.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cbDeck.Location = new System.Drawing.Point(170, 179);
            this.cbDeck.Name = "cbDeck";
            this.cbDeck.Size = new System.Drawing.Size(121, 21);
            this.cbDeck.TabIndex = 13;
            this.cbDeck.SelectedIndexChanged += new System.EventHandler(this.cbDeck_SelectedIndexChanged);
            // 
            // cbRoomNum
            // 
            this.cbRoomNum.FormattingEnabled = true;
            this.cbRoomNum.Location = new System.Drawing.Point(170, 251);
            this.cbRoomNum.Name = "cbRoomNum";
            this.cbRoomNum.Size = new System.Drawing.Size(121, 21);
            this.cbRoomNum.TabIndex = 14;
            this.cbRoomNum.SelectedIndexChanged += new System.EventHandler(this.cbRoomNum_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(441, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 153);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // labelGuestNum
            // 
            this.labelGuestNum.AutoSize = true;
            this.labelGuestNum.Location = new System.Drawing.Point(17, 364);
            this.labelGuestNum.Name = "labelGuestNum";
            this.labelGuestNum.Size = new System.Drawing.Size(156, 13);
            this.labelGuestNum.TabIndex = 16;
            this.labelGuestNum.Text = "Please Choose Your room Type";
            // 
            // PlanRoomNumber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelGuestNum);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbRoomNum);
            this.Controls.Add(this.cbDeck);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbPosition);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbGuest);
            this.Controls.Add(this.cbRoomType);
            this.Controls.Add(this.btnRoomNumCont);
            this.Controls.Add(this.label8);
            this.Name = "PlanRoomNumber";
            this.Size = new System.Drawing.Size(699, 515);
            this.Load += new System.EventHandler(this.PlanRoomNumber_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRoomNumCont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbRoomType;
        private System.Windows.Forms.ComboBox cbGuest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbPosition;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDeck;
        private System.Windows.Forms.ComboBox cbRoomNum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelGuestNum;
    }
}
