using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MojaAplikacjaSobota
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adresIp = Properties.Settings.Default.adresIp;
            string imie = Properties.Settings.Default.imie;
            string nazwisko =  Properties.Settings.Default.nazwisko;

            int krowa = 12;
            Console.WriteLine("Hello");
            Console.WriteLine(adresIp);
            Console.WriteLine(imie);
            Console.WriteLine(nazwisko);
           
            for (int i = 0; i < 10; i++) 
            {
                krowa += i;
                Console.WriteLine(krowa);
            }

            Console.WriteLine(krowa.ToString());
            Console.ReadLine();
        }
    }
}
