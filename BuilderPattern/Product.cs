using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    public class Product
    {
        private List<string> _parts = new List<string>();

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nProduct Parts --------");
            _parts.ForEach(elem => Console.WriteLine(elem));
        }

        public List<string> getProductList()
        {
            return _parts;
        }

    }
}