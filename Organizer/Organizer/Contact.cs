using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Organizer
{
    // Класс "Контакт" для записной книжки
    [Serializable()]
    public class Contact
    {
        // Конструктор класса
        public Contact(string fio, string adr, string phone, string email)
        {
            FIO = fio;
            Address = adr;
            PhoneNumber = phone;
            Email = email;
        }

        public string FIO; // ФИО
        public string Address; // Адрес
        public string PhoneNumber; // Номер телефона
        public string Email; // Адрес электронной почты
    }
}
