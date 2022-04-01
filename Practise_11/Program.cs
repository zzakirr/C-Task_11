using System;
using ClassLibrary;
namespace Practise_11
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Library library = new Library();
            Console.WriteLine("nece kitab isteyirsiz?");
            int CountBook = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < CountBook; i++)
            {
                Console.WriteLine("BookName:");
                string name = Console.ReadLine();
                Console.WriteLine("BookPrice:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Autor:");
                string autor = Console.ReadLine();
                Console.WriteLine("Genre:");
                string genre = Console.ReadLine();
                
               

               
                Product product = new Book()
                {
                    Name = name,
                    Price = price,
                    Autor = autor,
                    Genre = genre
                };
                library.AddProduct(product);
            }
            
            Console.WriteLine("nece jurnal isteyirsiz?");
            int CountJournal = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < CountJournal; i++)
            {
                Console.WriteLine("JournalName:");
                string name = Console.ReadLine();
                Console.WriteLine("JournalPrice:");
                double price = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Company:");
                string company = Console.ReadLine();
                
                Product product = new Journal()
                {
                    Name = name,
                    Price = price,
                    Company = company
                };
                library.AddProduct(product);
            }
            Console.WriteLine("------Filter by Price------");
            
            Product[] product1 = library.GetProductByPrice(15, 25);
            foreach (var item in product1)
            {
                item.GetInfo();
            }
            Console.WriteLine("------Filter by Name------");
            Product[] product2 = library.GetProductByName("gunluk");
            foreach (var item in product2)
            {
                item.GetInfo();
            }
           
        }
    }
}
