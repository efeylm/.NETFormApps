using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    class Kimlik
    {
        string ad; //private by default
        string soyad;
        string memleket;
        int yas;
        char cinsiyet;

        public Kimlik(string ad, string soyad, string memleket, int yas, char cinsiyet)
        {
            this.ad = ad;
            this.soyad = soyad;
            this.memleket = memleket;
            this.yas = yas;
            this.cinsiyet = cinsiyet;
        }

        public string AD
        {
            get { return ad; }
            set { ad = value; } 
        }

        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value.ToUpper(); }  
        }

        public string MEMLEKET
        {
            get { return memleket; }
            set { memleket = value;  }
        }
        public int YAS
        {
             get { return yas; }
             set { yas = value; }    
        }

        public char CINSIYET
        {
            get { return cinsiyet; }   
            set { cinsiyet = value; }
        }


    }
}
