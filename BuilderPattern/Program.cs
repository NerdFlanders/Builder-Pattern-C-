using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director _director = new Director();

            Builder _b1 = new ConcreteBuilderOne();
            Builder _b2 = new ConcreteBuilderTwo();

            _director.Construct(_b1);
            Product _p1 = _b1.GetResult();
            _p1.Show();

            _director.Construct(_b2);
            Product _p2 = _b2.GetResult();
            _p2.Show();

            Console.ReadKey();
        }
    }
}
