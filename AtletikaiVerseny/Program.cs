using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AtletikaiVerseny
{
    class Program
    {
        static List<Atleta> lista = new List<Atleta>();

        static void Beolvas()
        {
            StreamReader sr = new StreamReader("tavol.csv");
            while (!sr.EndOfStream)
            {
                lista.Add(new Atleta(sr.ReadLine()));
            }
            sr.Close();
            Console.WriteLine("1.Feladat: Adatok beolvasása.");
            Console.WriteLine("------------------------------------------");
        }

        static void masodik()
        {
            Console.WriteLine("2.feladat: Nevek és ugrások");
            foreach (var i in lista)
            {
                
                Console.WriteLine("{0,10}  {1}",i.VezNev,i.Ugras);
            }
        }

        static void harmadik()
        { 
              
        }
        static void negyedik()
        {
            int max = 0;
            string nev = "";
            foreach (var i in lista)
            {
                if (i.Ugras > max)
                {
                    max = i.Ugras;
                    nev = i.VezNev;
                }
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("4.feladat: A legnagyobb ugrás:");
            Console.WriteLine(nev + ": " + max);
        }

        static void otodik()
        {
            double osszeg = 0;
            double atlag = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszeg = osszeg + lista[i].Ugras;
            }
            atlag = osszeg / lista.Count;
        }
        static void hatodik()
        {
            StreamWriter sw = new StreamWriter("versenyzok.txt");
            foreach (var i in lista)
            {
                sw.WriteLine(i.VezNev +";"+ i.Rajtszam);
            }
            sw.Close();
        }

        static void Main(string[] args)
        {
            Beolvas();
            masodik();
            negyedik();
            otodik();
            hatodik();
            Console.ReadKey();
        }
    }
}
