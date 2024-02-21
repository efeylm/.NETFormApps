using System.Text;
using System.Threading;

namespace Ornek_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Kimlik id= new Kimlik("efe","yalım","bursa",20,'e');
            id.AD = "ahmet";
            Console.WriteLine(id.AD);
            Console.ReadKey();
        }

    }
}