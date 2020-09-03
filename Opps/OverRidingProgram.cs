using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class OverRidingProgram
    {
        public void Test()
        {
            Console.WriteLine("parent");
        }
        public virtual void Show()
        {
            Console.WriteLine("parent show");
        }
        public virtual void Display()
        {
            Console.WriteLine("parent display");
        }
    }

    public class Over : OverRidingProgram
    {
        public override void Show()
        {
            Console.WriteLine("child method show");
        }
        public void Display()
        {
            Console.WriteLine("parent display");
        }
        public static void Main(string[] args)
        {
            Over o = new Over();
            OverRidingProgram r = o;//call by reference
            o.Show();
            o.Display();


        }
    }
}
