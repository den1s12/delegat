using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            student student = new student();
            ShowMessage method = Show;
            student.Move(7, method);
        }
        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}
