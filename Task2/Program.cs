//Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
//    Потрібно: Створити статичний клас FindAndReplaceManager з методом void FindNext(string str) 
//    для пошуку за книгою з прикладу уроку 005_Book. 
//    При виклику цього методу проводиться послідовний пошук рядка в книзі

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World";
            str.FindNext();
        }
    }
}