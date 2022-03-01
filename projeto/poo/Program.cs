using System;
using poo.Entities;

namespace poo
{
    class Program
    {
        static void Main(string[] args)
        {
            Kight arus = new Kight("Arus", 23, "knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(10));
        }
    }
}
