using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vislice
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Dobrodošli v igri Vislice !");
            string[] imena = new string[]   {"administrator", "afrika", "adrenalin", "akupunktura",
                                             "bomba", "bober", "biljard", "banka",
                                             "cigara", "cimbale", "certifikat", "cenik",
                                             "diagonala","dimenzija", "dramatik", "distrakcija",
                                             "egoist", "elektrika", "estonija", "evropa",
                                             "flavta", "farmacija", "filipinec", "fizioterapevt",
                                             "gravitacija", "gorazd", "gorila", "gorivo",
                                             "hibernacija", "hierarhija", "hinduizem", "helij",
                                             "indija", "inekcija", "indonezija", "iglavec",
                                             "jama", "jugoslavija", "jogurt", "janez",
                                             "kreacija", "korozija", "kemoterapija","kartoteka",
                                             "lama", "limonada", "lekcija", "liga",
                                             "miza", "medved", "mizar", "muza",
                                             "nauk", "namenilnik", "nizozemska", "nagrada",
                                             "opera", "operater", "opcija", "orangutan",
                                             "padalec", "pamet", "programer", "papagaj",
                                             "regrad", "rum", "regeneracija", "redukcija",
                                             "seks","stvaritev", "sirarna","samostan",
                                             "tibor", "tapeta", "trident", "transakcija",
                                             "urar", "uprizoritev", "uprava", "ukaz",
                                             "vrata", "vizija", "vertikala", "videoteka",
                                             "zapor", "zagovor", "zavesa", "zmaj"};

            Random rnd = new Random();
            string s = imena[rnd.Next(-1, imena.Length + 1)];
            char[] skrit = new char[s.Length];
            string uporabiCrke = "";                        

            for (int i = 0; i < skrit.Length; i++)
            {                
                skrit[i] = '_';
            }
                        
            int z;
            for (z = 0; z < 6; )
            {
                Console.Write("Vpišite črko: ");
                char y = Char.ToLower(char.Parse(Console.ReadLine()));
                Console.Clear();

                bool f = false;
                for (int i = 0; i < skrit.Length; i++)
                {
                    if (s[i] == y)
                    {
                        skrit[i] = y;
                        f = true;
                    }
                }
                if (!f)
                {
                    z++;
                    uporabiCrke += y + " ";
                }

                switch (z)
                {
                    case 1:
                        Console.WriteLine("\n |_________");
                        break;
                    case 2:
                        Console.WriteLine("\n |/  \n |  \n |  \n |  \n |  \n |  \n |_________ ");
                        break;
                    case 3:
                        Console.WriteLine("\n  _______ \n |/      | \n |  \n |  \n |  \n |  \n |  \n |_________ ");
                        break;
                    case 4:
                        Console.WriteLine("\n  _______ \n |/      | \n |      (_) \n |  \n |  \n |  \n |  \n |_________ ");
                        break;
                    case 5:
                        Console.WriteLine("\n  _______ \n |/      | \n |      (_) ");                        
                        Console.WriteLine(@" |      \|/  ");
                        Console.WriteLine(" |  \n |  \n |  \n |_________ ");                        
                        break;                    
                }

                bool d = true;
                for (int x = 0; x < skrit.Length; x++)
                {
                    Console.Write(skrit[x] + " ");
                    if(skrit[x]=='_')
                    {
                        d = false;
                    }
                }
                if (d == true) break;
                
                Console.WriteLine("\nŽe uporabljene črke: " + uporabiCrke);                
            }            

            if(z==6)
            {
                Console.WriteLine("\n  _______ \n |/      | \n |      (_) ");
                Console.WriteLine(@" |      \|/  ");
                Console.WriteLine(" |       |  ");
                Console.WriteLine(@" |      / \  ");
                Console.WriteLine(" |  \n |_________ ");

                Console.WriteLine("Na žalost so vas obesili!");
                Console.WriteLine("Iskana beseda je bila: " + s);
            }
            else
            {
                Console.WriteLine("\nBravo, uspelo vam je!");
            }

            Console.ReadKey();

            
            
 //    _________
 //    |/      |
 //    |      (_)
 //    |      \|/
 //    |       |
 //    |      / \
 //    |
 //    |_________
        }
    }
}
