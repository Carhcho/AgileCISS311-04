using System;

namespace dropbox04
{
    class Program
    {
        static void Main(string[] args)
        {
            Perishable p = new Perishable("Egg", 45);
            NonPerishable np = new NonPerishable("Canned Bean", new DateTime(2018, 4, 21));

            DisplayInstruction<Perishable>(p);
            DisplayInstruction<NonPerishable>(np);
            Console.ReadKey();
        }
        static void DisplayInstruction<E>(E e)
        {
            Console.WriteLine(e);
        }
    }
}
