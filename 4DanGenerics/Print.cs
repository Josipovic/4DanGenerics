using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DanGenerics
{
    class Print
    {
        public void Ispis(int x)
        {

            Console.WriteLine("Upisali ste" + x);

        }

        //preopterecivanje
        public void Ispis(float x)
        {

            Console.WriteLine("Upisali ste" + x);
        }

        //jos jedno preopterecivanje

        public void Ispis(string x){

            Console.WriteLine("Upisali ste" + x);

        }

        public void Ispis(bool x) {

            Console.WriteLine("Upisali ste" + x);
        }

        public void Ispis(Nesto x) {
            Console.WriteLine("Upisali ste" + x.k);
        }
    }
}
