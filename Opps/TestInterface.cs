using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opps
{
    public class TestInterface
    {
        interface IClass
        {
            void Draw();
        }
        public class Rectangle : IClass
        {
            public void Draw()
            {
                Console.WriteLine("drawing rectangle...");
            }
        }
        public class Circle : IClass
        {
            public void Draw()
            {
                Console.WriteLine("drawing circle...");
            }
        }
        
             public static void Main(string[] args)
        {
            IClass d;
            d = new Rectangle();
            d.Draw();
            d = new Circle();
            d.Draw();
        }
    }
}
