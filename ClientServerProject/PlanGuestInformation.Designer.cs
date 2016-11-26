namespace ClientServerProject
{
    partial class PlanGuestInformation
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
            this.btnGuestCont = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.tbLName = new System.Windows.Forms.TextBox();
            this.tbFname = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbGuest = new System.Windows.Forms.ListBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.tbPhoneNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddr = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.btnChange = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuestCont
            // 
            this.btnGuestCont.Location = new System.Drawing.Point(565, 438);
            this.btnGuestCont.Name = "btnGuestCont";
            this.btnGuestCont.Size = new System.Drawing.Size(75, 23);
            this.btnGuestCont.TabIndex = 33;
            this.btnGuestCont.Text = "Continue";
            this.btnGuestCont.UseVisualStyleBackColor = true;
            this.btnGuestCont.Click += new System.EventHandler(this.btnGuestCont_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radMale);
            this.groupBox2.Controls.Add(this.radFemale);
            this.groupBox2.Location = new System.Drawing.Point(76, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 76);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gender";
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(36, 33);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 2;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(115, 33);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 1;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // tbLName
            // 
            this.tbLName.Location = new System.Drawing.Point(168, 98);
            this.tbLName.Name = "tbLName";
            this.tbLName.Size = new System.Drawing.Size(108, 20);
            this.tbLName.TabIndex = 29;
            // 
            // tbFname
            // 
            this.tbFname.Location = new System.Drawing.Point(168, 67);
            this.tbFname.Name = "tbFname";
            this.tbFname.Size = new System.Drawing.Size(108, 20);
            this.tbFname.TabIndex = 28;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(73, 132);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(66, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "Date of Birth";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(73, 101);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 26;
            this.label15.Text = "Last Name";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(73, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "First Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(202, 339);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 34;
            this.btnSave.Text = "Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbGuest
            // 
            this.lbGuest.FormattingEnabled = true;
            this.lbGuest.Location = new System.Drawing.Point(430, 104);
            this.lbGuest.Name = "lbGuest";
            this.lbGuest.Size = new System.Drawing.Size(127, 160);
            this.lbGuest.TabIndex = 35;
            this.lbGuest.SelectedIndexChanged += new System.EventHandler(this.lbGuest_SelectedIndexChanged);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(482, 307);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(75, 25);
            this.btnDel.TabIndex = 36;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // tbPhoneNum
            // 
            this.tbPhoneNum.Location = new System.Drawing.Point(168, 161);
            this.tbPhoneNum.Name = "tbPhoneNum";
            this.tbPhoneNum.Size = new System.Drawing.Size(108, 20);
            this.tbPhoneNum.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "Phone Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 222);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Email";
            // 
            // txtAddr
            // 
            this.txtAddr.Location = new System.Drawing.Point(168, 191);
            this.txtAddr.Name = "txtAddr";
            this.txtAddr.Size = new System.Drawing.Size(108, 20);
            this.txtAddr.TabIndex = 45;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(168, 219);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(108, 20);
            this.txtEmail.TabIndex = 46;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(482, 276);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 25);
            this.btnEdit.TabIndex = 47;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // datePicker
            // 
            this.datePicker.CustomFormat = "yyyy-MM-dd";
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePicker.Location = new System.Drawing.Point(168, 130);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(109, 20);
            this.datePicker.TabIndex = 48;
            this.datePicker.Value = new System.DateTime(2016, 11, 3, 0, 0, 0, 0);
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(191, 370);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(85, 25);
            this.btnChange.TabIndex = 49;
            this.btnChange.Text = "Save Changes";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // PlanGuestInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAddr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPhoneNum);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lbGuest);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnGuestCont);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tbLName);
            this.Controls.Add(this.tbFname);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Name = "PlanGuestInformation";
            this.Size = new System.Drawing.Size(699, 515);
            this.Load += new System.EventHandler(this.PlanGuestInformation_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuestCont;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.TextBox tbLName;
        private System.Windows.Forms.TextBox tbFname;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ListBox lbGuest;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.TextBox tbPhoneNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddr;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Button btnChange;
    }
}
