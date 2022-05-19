using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void ShowMessage(string message);
    public class student
    {
        public void Move(int distance, ShowMessage method)
        {
            for (int i = 1; i <= distance; i++)
            {
                Thread.Sleep(1000);
                method(string.Format("Идет перемещение... Пройдено километров: {0}", i));
            }
        }
    }
}


