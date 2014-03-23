using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing.Printing;

namespace Organizer
{
    public partial class Organizer : Form
    {
        const int sl = 8;
        public Organizer()
        {
            InitializeComponent();
        }

        public List <Contact> Contacts; // Массив контактов
        public List <Note> Notes; // Массив записей

        private void Organizer_Load(object sender, EventArgs e)
        {
            Contacts = new List<Contact>();
            Notes = new List<Note>();
            //Contacts.Add(new Contact("FIO", "Address", "Phone", "e-mail"));
            //Notes.Add(new Note("Text", new DateTime()));
            //IFormatter formatter = new BinaryFormatter();
            //Stream stream = new FileStream("Contacts.org", FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream, Contacts);
            //stream.Close();
            //stream = new FileStream("Notes.org", FileMode.Create, FileAccess.Write, FileShare.None);
            //formatter.Serialize(stream, Notes);
            //stream.Close();

            // Десериализация контактов
            Stream StreamContacts = new FileStream("Contacts.org", FileMode.Open);
            IFormatter formatter = new BinaryFormatter();
            Contacts = (List<Contact>)formatter.Deserialize(StreamContacts);
            StreamContacts.Close();

            // Десериализация заметок
            Stream StreamNotes = new FileStream("Notes.org", FileMode.Open);
            Notes = (List<Note>)formatter.Deserialize(StreamNotes);
            StreamNotes.Close();

            // Заполнение контакт-листа
            foreach (Contact c in Contacts) chListContacts.Items.Add(c.FIO);

            // Заполнение списка событий
            foreach (Note n in Notes)
            {
                int len = n.Text.Length;
                len = (len > sl) ? sl : len;
                chListNotes.Items.Add(n.Date.Date.Day.ToString("00") + "-" + n.Date.Date.Month.ToString("00") +
                    "-" + n.Date.Year.ToString("0000") + " - " + n.Text.Substring(0, len) + ((n.Text.Length > sl) ? "..." : ""));
                // Напоминание о событии, если до него осталось не более 3-х дней
                if (n.Date.Date < DateTime.Now.Date) continue;
                TimeSpan ts = n.Date.Date - DateTime.Now.Date;
                if (ts.Days <= 3) MessageBox.Show(n.Text, "Дата: " + n.Date.Date.Day.ToString("00") + "-" + n.Date.Date.Month.ToString("00") +
                    "-" + n.Date.Year.ToString("0000"));
            }

            radAllNotes.Checked = true;
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            IFormatter formatter = new BinaryFormatter();
            // Сериализация контактов
            Stream stream = new FileStream("Contacts.org", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Contacts);
            stream.Close();
            // Сериализация заметок
            stream = new FileStream("Notes.org", FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, Notes);
            stream.Close();
        }

        private void chListContacts_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = chListContacts.SelectedIndex;
            if (ind == -1) return;
            tbFIO.Text = Contacts[ind].FIO;
            tbAddress.Text = Contacts[ind].Address;
            tbPhone.Text = Contacts[ind].PhoneNumber;
            tbEmail.Text = Contacts[ind].Email;
        }

        private void chListNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = chListNotes.SelectedIndex;
            if (ind == -1) return;
            if (radAllNotes.Checked) tbNoteText.Text = Notes[ind].Text;
            else tbNoteText.Text = Notes.FindAll(element => element.Date.Date == dateTimePicker1.Value.Date)[ind].Text;
        }

        private void tbNoteText_TextChanged(object sender, EventArgs e)
        {
            int ind = chListNotes.SelectedIndex;
            if (ind == -1) return;
            DateTime Date;
            if (radAllNotes.Checked)
            {
                Notes[ind].Text = tbNoteText.Text;
                Date = Notes[ind].Date.Date;
            }
            else
            {
                Notes.FindAll(element => element.Date.Date == dateTimePicker1.Value.Date)[ind].Text = tbNoteText.Text;
                Date = Notes.FindAll(element => element.Date.Date == dateTimePicker1.Value.Date)[ind].Date.Date;
            }
            int len = Notes[ind].Text.Length;
            len = (len > sl) ? sl : len;
            chListNotes.Items[ind] = Date.Day.ToString("00") + "-" + Date.Month.ToString("00") +
    "-" + Date.Year.ToString("0000") + " - " + tbNoteText.Text.Substring(0, len) + ((Notes[ind].Text.Length > sl) ? "..." : "");
        }

        private void tbFIO_TextChanged(object sender, EventArgs e)
        {
            int ind = chListContacts.SelectedIndex;
            if (ind == -1) return;
            Contacts[ind].FIO = tbFIO.Text;
            chListContacts.Items[ind] = tbFIO.Text;
        }

        private void tbAddress_TextChanged(object sender, EventArgs e)
        {
            int ind = chListContacts.SelectedIndex;
            if (ind == -1) return;
            Contacts[ind].Address = tbAddress.Text;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            int ind = chListContacts.SelectedIndex;
            if (ind == -1) return;
            Contacts[ind].PhoneNumber = tbPhone.Text;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            int ind = chListContacts.SelectedIndex;
            if (ind == -1) return;
            Contacts[ind].Email = tbEmail.Text;
        }

        private void btnAddContact_Click(object sender, EventArgs e)
        {
            Contacts.Add(new Contact("ФИО", "Адрес", "Телефон", "e-mail"));
            chListContacts.Items.Add("ФИО");
            chListContacts.SelectedIndex = chListContacts.Items.Count - 1;
        }

        private void btnDelContacts_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (int ind in chListContacts.CheckedIndices)
                Contacts.RemoveAt(ind-(i++));
            chListContacts.Items.Clear();
            foreach (Contact c in Contacts) chListContacts.Items.Add(c.FIO);
            tbFIO.Text = tbAddress.Text = tbPhone.Text = tbEmail.Text = "";
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            Note n = new Note("Заметка", dateTimePicker1.Value.Date);
            Notes.Add(n);
            int len = n.Text.Length;
            len = (len > sl) ? sl : len;
            chListNotes.Items.Add(n.Date.Date.Day.ToString("00") + "-" + n.Date.Date.Month.ToString("00") +
                "-" + n.Date.Year.ToString("0000") + " - " + n.Text.Substring(0, len) + ((n.Text.Length > sl) ? "..." : ""));
            chListNotes.SelectedIndex = chListNotes.Items.Count - 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            int [] indexes = new int [chListNotes.CheckedIndices.Count];
            foreach (int ind in chListNotes.CheckedIndices)
            {
                if (radAllNotes.Checked) indexes[i++] = ind;
                else indexes[i++] = Notes.FindIndex(element => element == Notes.FindAll(el => el.Date.Date == dateTimePicker1.Value.Date)[ind]);
            }
            i = 0;
            foreach (int ind in indexes)
                Notes.RemoveAt(ind-(i++));
            chListNotes.Items.Clear();
            foreach (Note n in Notes)
            {
                if (!radAllNotes.Checked)
                    if (n.Date.Date != dateTimePicker1.Value.Date) continue;
                int len = n.Text.Length;
                len = (len > sl) ? sl : len;
                chListNotes.Items.Add(n.Date.Date.Day.ToString("00") + "-" + n.Date.Date.Month.ToString("00") +
                    "-" + n.Date.Year.ToString("0000") + " - " + n.Text.Substring(0, len) + ((n.Text.Length > sl) ? "..." : ""));
            }
            tbNoteText.Text = "";
        }

        private void radAllNotes_CheckedChanged(object sender, EventArgs e)
        {
            if (!radAllNotes.Checked) return;
            chListNotes.Items.Clear();
            foreach (Note n in Notes)
            {
                int len = n.Text.Length;
                len = (len > sl) ? sl : len;
                chListNotes.Items.Add(n.Date.Date.Day.ToString("00") + "-" + n.Date.Date.Month.ToString("00") +
                    "-" + n.Date.Year.ToString("0000") + " - " + n.Text.Substring(0, len) + ((n.Text.Length > sl) ? "..." : ""));
            }
        }

        private void radByDates_CheckedChanged(object sender, EventArgs e)
        {
            if (!radByDates.Checked) return;
            chListNotes.Items.Clear();
            foreach (Note n in Notes)
            {
                if (n.Date.Date != dateTimePicker1.Value.Date) continue;
                int len = n.Text.Length;
                len = (len > sl) ? sl : len;
                chListNotes.Items.Add(n.Date.Date.Day.ToString("00") + "-" + n.Date.Date.Month.ToString("00") +
                    "-" + n.Date.Year.ToString("0000") + " - " + n.Text.Substring(0, len) + ((n.Text.Length > sl) ? "..." : ""));
            }
            tbNoteText.Text = "";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (!radByDates.Checked) return;
            chListNotes.Items.Clear();
            foreach (Note n in Notes)
            {
                if (n.Date.Date != dateTimePicker1.Value.Date) continue;
                int len = n.Text.Length;
                len = (len > sl) ? sl : len;
                chListNotes.Items.Add(n.Date.Date.Day.ToString("00") + "-" + n.Date.Date.Month.ToString("00") +
                    "-" + n.Date.Year.ToString("0000") + " - " + n.Text.Substring(0, len) + ((n.Text.Length > sl) ? "..." : ""));
            }
            tbNoteText.Text = "";
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
