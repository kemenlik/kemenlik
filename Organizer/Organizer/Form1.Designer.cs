namespace Organizer
{
    partial class Organizer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelContacts = new System.Windows.Forms.Button();
            this.btnAddContact = new System.Windows.Forms.Button();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbFIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chListContacts = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAddNote = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.radByDates = new System.Windows.Forms.RadioButton();
            this.radAllNotes = new System.Windows.Forms.RadioButton();
            this.tbNoteText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chListNotes = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSaveAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelContacts);
            this.groupBox1.Controls.Add(this.btnAddContact);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbPhone);
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbFIO);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.chListContacts);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(395, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 346);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адресная книга";
            // 
            // btnDelContacts
            // 
            this.btnDelContacts.Location = new System.Drawing.Point(211, 218);
            this.btnDelContacts.Name = "btnDelContacts";
            this.btnDelContacts.Size = new System.Drawing.Size(175, 23);
            this.btnDelContacts.TabIndex = 11;
            this.btnDelContacts.Text = "Удалить выбранные контакты";
            this.btnDelContacts.UseVisualStyleBackColor = true;
            this.btnDelContacts.Click += new System.EventHandler(this.btnDelContacts_Click);
            // 
            // btnAddContact
            // 
            this.btnAddContact.Location = new System.Drawing.Point(211, 189);
            this.btnAddContact.Name = "btnAddContact";
            this.btnAddContact.Size = new System.Drawing.Size(175, 23);
            this.btnAddContact.TabIndex = 10;
            this.btnAddContact.Text = "Добавить новый контакт";
            this.btnAddContact.UseVisualStyleBackColor = true;
            this.btnAddContact.Click += new System.EventHandler(this.btnAddContact_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(272, 124);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(178, 20);
            this.tbEmail.TabIndex = 9;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(272, 98);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(178, 20);
            this.tbPhone.TabIndex = 8;
            this.tbPhone.TextChanged += new System.EventHandler(this.tbPhone_TextChanged);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(272, 72);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(178, 20);
            this.tbAddress.TabIndex = 7;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            // 
            // tbFIO
            // 
            this.tbFIO.Location = new System.Drawing.Point(272, 46);
            this.tbFIO.Name = "tbFIO";
            this.tbFIO.Size = new System.Drawing.Size(178, 20);
            this.tbFIO.TabIndex = 6;
            this.tbFIO.TextChanged += new System.EventHandler(this.tbFIO_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(208, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "e-mail -";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Телефон -";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Адрес -";
            // 
            // chListContacts
            // 
            this.chListContacts.FormattingEnabled = true;
            this.chListContacts.Location = new System.Drawing.Point(27, 49);
            this.chListContacts.Name = "chListContacts";
            this.chListContacts.Size = new System.Drawing.Size(175, 274);
            this.chListContacts.TabIndex = 2;
            this.chListContacts.SelectedIndexChanged += new System.EventHandler(this.chListContacts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ФИО -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Контакты";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btnAddNote);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.radByDates);
            this.groupBox2.Controls.Add(this.radAllNotes);
            this.groupBox2.Controls.Add(this.tbNoteText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.chListNotes);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 346);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Записная книжка";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(182, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Удалить выбранные записи";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAddNote
            // 
            this.btnAddNote.Location = new System.Drawing.Point(6, 308);
            this.btnAddNote.Name = "btnAddNote";
            this.btnAddNote.Size = new System.Drawing.Size(162, 23);
            this.btnAddNote.TabIndex = 8;
            this.btnAddNote.Text = "Добавить новую запись";
            this.btnAddNote.UseVisualStyleBackColor = true;
            this.btnAddNote.Click += new System.EventHandler(this.btnAddNote_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(40, 43);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Дата -";
            // 
            // radByDates
            // 
            this.radByDates.AutoSize = true;
            this.radByDates.Location = new System.Drawing.Point(95, 19);
            this.radByDates.Name = "radByDates";
            this.radByDates.Size = new System.Drawing.Size(65, 17);
            this.radByDates.TabIndex = 5;
            this.radByDates.TabStop = true;
            this.radByDates.Text = "По дате";
            this.radByDates.UseVisualStyleBackColor = true;
            this.radByDates.CheckedChanged += new System.EventHandler(this.radByDates_CheckedChanged);
            // 
            // radAllNotes
            // 
            this.radAllNotes.AutoSize = true;
            this.radAllNotes.Location = new System.Drawing.Point(6, 19);
            this.radAllNotes.Name = "radAllNotes";
            this.radAllNotes.Size = new System.Drawing.Size(83, 17);
            this.radAllNotes.TabIndex = 4;
            this.radAllNotes.TabStop = true;
            this.radAllNotes.Text = "Все записи";
            this.radAllNotes.UseVisualStyleBackColor = true;
            this.radAllNotes.CheckedChanged += new System.EventHandler(this.radAllNotes_CheckedChanged);
            // 
            // tbNoteText
            // 
            this.tbNoteText.Location = new System.Drawing.Point(182, 88);
            this.tbNoteText.Multiline = true;
            this.tbNoteText.Name = "tbNoteText";
            this.tbNoteText.Size = new System.Drawing.Size(178, 214);
            this.tbNoteText.TabIndex = 3;
            this.tbNoteText.TextChanged += new System.EventHandler(this.tbNoteText_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(179, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Текст записи";
            // 
            // chListNotes
            // 
            this.chListNotes.FormattingEnabled = true;
            this.chListNotes.Location = new System.Drawing.Point(6, 88);
            this.chListNotes.Name = "chListNotes";
            this.chListNotes.Size = new System.Drawing.Size(170, 214);
            this.chListNotes.TabIndex = 1;
            this.chListNotes.SelectedIndexChanged += new System.EventHandler(this.chListNotes_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Записи";
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.Location = new System.Drawing.Point(304, 364);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.Size = new System.Drawing.Size(171, 23);
            this.btnSaveAll.TabIndex = 2;
            this.btnSaveAll.Text = "Сохранить все изменения";
            this.btnSaveAll.UseVisualStyleBackColor = true;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // Organizer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 393);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Organizer";
            this.Text = "Электронный органайзер";
            this.Load += new System.EventHandler(this.Organizer_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbFIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckedListBox chListContacts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDelContacts;
        private System.Windows.Forms.Button btnAddContact;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radByDates;
        private System.Windows.Forms.RadioButton radAllNotes;
        private System.Windows.Forms.TextBox tbNoteText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox chListNotes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAddNote;
        private System.Windows.Forms.Button btnSaveAll;

    }
}

