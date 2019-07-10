using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4DanGenerics
{
    class PrintGeneric
    {
        public void Print<T>(T d)

        {     //umjesto preopterecenih metoda u jednoj funkciji pomocu generica je sve rjeseno

            Console.WriteLine("Upisali ste" + d);
        }
        public void JesuLiJednaki<T>(T a,T b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine("Jednaki su");
            }
            else {
                Console.WriteLine("Nisu jednaki");
            }
        }

        public void IspisixPuta<T>(T poruka, int broj)

        {

            for (int i = 0; i > broj; i++) {
                Console.WriteLine(poruka);
            }

        }
    }
}
