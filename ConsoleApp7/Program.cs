using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    // ********
    // klasa: sprawdzanieLiczby
    // opis: klasa sprawdza czy suma cyfr liczby jest podzielna przez 4
    // pola: - tablica - tablica 10000 losowych liczb
    // autor: W.T
    // ********
    public class sprawdzanieLiczby
    {
        private int[] tablica = new int[10000];
        private int liczba;

      

        public int wprowadzLiczbyDoTablicy()
        {
            Random rand = new Random();
            for (int i = 0; i < 10000; i++)
            {
                
                tablica[i] = rand.Next(1, 10000);
            }
            sprawdzCzyJestCzworka();
            return 1;
        }

        public bool sprawdzCzyJestCzworka()
        {
            for (int i = 0; i < tablica.Length; i++)
            {
                int czyCzworka = 0;
                string liczbaString = tablica[i].ToString();
                for (int j = 0; j < liczbaString.Length; j++)
                {
                    czyCzworka += (int)(liczbaString[j] - '0');
                    
                }
             
                

                if (czyCzworka % 4 == 0)
                {
                    Console.WriteLine("Liczba " + tablica[i] + " jest czworkowa");
                }
                else
                {
                    Console.WriteLine("Liczba " + tablica[i] + "nie jest czworkowa");
                }
            }
            return true;
        }

        public bool sprawdzCzyCalaLiczbaJestCzworkowa(string liczba)
        {
            int czyCzworka = 0;
            for (int i = 0; i < liczba.Length; i++)
            {
                czyCzworka += (int)(liczba[i]-'0');

                
            }

            if(czyCzworka % 4 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            sprawdzanieLiczby liczby = new sprawdzanieLiczby();

            liczby.wprowadzLiczbyDoTablicy();
           Console.WriteLine( liczby.sprawdzCzyCalaLiczbaJestCzworkowa("1236"));

        }
    }
}
