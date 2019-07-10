using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DanGenerics
{
    //generics-generici-omogucuju dizajniranje klasa i metoda na nacin da ne ovise o tipu podataka

    class Program
    {
        static void Main(string[] args)
        {
            //Print p = new Print();
            //p.Ispis(5);

            PrintGeneric a = new PrintGeneric();
            a.Print(4);
            a.JesuLiJednaki(2, 2);
            a.IspisixPuta(2, 2);
            Console.ReadLine();
        }
    }
}
