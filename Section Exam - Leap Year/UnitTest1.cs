using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Section_Exam___Leap_Year
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trace.Write("Please enter a year value: ");
            int enteredYear = Convert.ToInt16(Console.ReadLine());
            //int enteredYear = 400;
            int divBy4 = enteredYear % 4;
            int divBy100 = enteredYear % 100;
            int divBy400 = enteredYear % 400;


            if (divBy4 == 0 && divBy100 == 0 && divBy100 == 0)
            {
                Console.WriteLine("Leap year: yes");
            }
            if (divBy4 == 0 && divBy100 == 0)
            {
                Console.WriteLine("Leap year: yes");
            }



            Console.ReadLine();



        }
    }
}