using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Book:Product
    {
        public string Autor;
        public string Genre;
        public override void GetInfo()
        {
            Console.WriteLine($"Name:{Name} Price:{Price} Autor:{Autor} Genre:{Genre}");
        }
    }
}
