using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Kisiler
    {
        public void kisilistesi(string adsoyad)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(adsoyad);
            }
        }
    }
}
