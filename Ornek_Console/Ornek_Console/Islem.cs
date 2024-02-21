using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    internal class Islem
    {
        public int topla(int s1,int s2)
        {
            int s3=s1+s2;
            Console.WriteLine("Sonuc: "+ s3);
            return s3; 
        }

        public int kare(int val)
        {
            int sqr = val * val;
            Console.WriteLine("Sonuc : "+sqr);
            return sqr;
        }
    }
}
