using System;

namespace Action
{
    class Program
    {       
        static void Main(string[] args)
        {
            Student student = new Student();
            Action<string> method = Show;
            student.Move(7, method);
        }
        static void Show(string message)
        {
            Console.WriteLine(message);
        }
    }
}

