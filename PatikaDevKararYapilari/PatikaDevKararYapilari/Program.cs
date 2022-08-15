using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatikaDevKararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            //if-else yapısı

            if (time >= 6 && time < 11)
                Console.WriteLine("Günaydın");
            else if (time <= 18)
                Console.WriteLine("İyi günler");
            else
                Console.WriteLine("İyi geceler");


            //Ternary If : Ternary operatörü üç işlem alan tek operatördür. Bir bakıma if else yapısına da çok benzerlik göstermektedir.

            string sonuc = time >= 6 && time < 11 ? "Günaydın." : time <= 18 ? "iyi günler." : "İyi geceler.";

            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
