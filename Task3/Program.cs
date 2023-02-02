//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Розширте приклад уроку 005_Book, створивши в класі Book вкладений клас Notes, який дозволить зберігати нотатки читача.

using System;
using System.Text;

namespace Task3
{
    class Book
    {
        public void FindNext(string str)
        {
            Console.WriteLine("Пошук рядка : " + str);
        }

        public class Notes
        {
            public void Save(string str)
            {
                Console.WriteLine("Save notes: "+str);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Book.Notes notes = new Book.Notes();
            notes.Save("Hello");
            Book book = new Book();
            book.FindNext("World");
        }
    }
}