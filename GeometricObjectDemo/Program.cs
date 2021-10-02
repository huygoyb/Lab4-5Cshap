using System;

namespace GeometricObjectDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Circle cl = new Circle(2.45, "Blue", 23);
            Console.WriteLine("Circle before change: "+ cl.ToString());
            // using properties
            cl.PColor = "red";
            cl.PWeight = 2.56;

            Console.WriteLine("Circle after change: " +cl.ToString());
            Console.ReadLine();
        }
    }
}