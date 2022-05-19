using System;

namespace delegat
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHelper helper = new StringHelper();

            CountDelegate d1 = helper.GetCount;
            CountDelegate d2 = helper.GetCountSymbolA;

            string testString = "LAMP";

            Console.WriteLine("Общее количество симыолов: {0}", TestDelegate(d1, testString));
            Console.WriteLine("Количество симыолов A: {0}", TestDelegate(d2, testString));

            Console.ReadLine();
        }
        static int TestDelegate(CountDelegate method, string testString)
        {
            return method(testString);
        }
    }
}
