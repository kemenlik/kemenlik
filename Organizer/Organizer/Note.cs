using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Organizer
{
    // Класс "Запись (заметка)" для записной книжки
    [Serializable()]
    public class Note
    {
        // Конструктор класса
        public Note(string text, DateTime date)
        {
            Text = text;
            Date = date;
        }

        public string Text; // Текст заметки
        public DateTime Date; // Дата для привязки заметки
    }
}
