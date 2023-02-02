//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Потрібно: створити розширюючий метод для цілого масиву, який сортує елементи масиву за зростанням. 

namespace Task4
{
    public static class ExtMethods
    {
        public static int[] SortAsc(this int[] arr)
        {
            Array.Sort(arr);
            return arr;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 5, 6, 1, 2, 3 };
            foreach(int item in arr)
                Console.WriteLine("Before sort: "+item);
            arr.SortAsc();
            foreach(int item in arr)
                Console.WriteLine("After sort: "+ item);
        }        
    }
}