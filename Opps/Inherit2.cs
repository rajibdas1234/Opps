using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class Inheritance
    {


        public Inheritance()
        {
            Console.WriteLine("This is parent class constructer");
        }
        public Inheritance(int x, int y)
        {
            Console.WriteLine("Parent" + x * y);

        }
        public void Methaod1()
        {
            Console.WriteLine("Method first");
        }

    }
    public class Inherit2 : Inheritance
    {
        public Inherit2()
        {
            Console.WriteLine("This is child class constructer");

        }
        public Inherit2(int x, int y) : base(10, 20)
        {
            Console.WriteLine("Child" + x * y);
        }
        public void Method2()
        {
            Console.WriteLine("Method Second");
        }
        public static void Main(string[] args)
        {
            Inherit2 i1 = new Inherit2();
            i1.Methaod1();
            i1.Method2();

            //Inheritance i2 = i1;
            // i2.Methaod1();
            //  i2.Methaod2();//not possable duu to i2 ia a reference of parent class

            Inherit2 i3 = new Inherit2(1, 30);

            Console.ReadKey();
        }
    }
}

