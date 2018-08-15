using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ekstra_Opgave_Lommeregner
{
    class Program
    {
        static void Main(string[] args)
        {
            //Indikere at det er her programmet starter (er nødvendigt vis man vil gå tilbage til start senere i programmet)
            Start:

            //Menuen   //Input
            Console.WriteLine("Velkommen til lommeregneren");
            Console.WriteLine("Kun 2 tal tilladt");
            Console.WriteLine("Eksempel : 3 * 3");
            Console.Write("Indtast regnestykke : ");
            string input = Console.ReadLine();
            //"string[]" Opretter et array som hedder "tal1" og "input.Split('/') osv." sørger for at der bliver splittet efter hvert tegn
            string[] tal1 = input.Split('/', '*', '-', '+');

            //"(input.All(Char.IsLetter)" sørger for at man ikke kan skrive bokstaver.
            //"tal1[0].Trim().All(Char.IsLetter)" sørger for vis tal1 indeholder bokstaver så er der fejl ".Trim" sørger for at fjerne melllemrum
            if (input.All(Char.IsLetter) || tal1[0].Trim().All(Char.IsLetter) || tal1[1].Trim().All(Char.IsLetter))
            {
                Console.Clear();
                Console.WriteLine("Forkert indtastning");
                Console.ReadKey();
                Console.Clear();
                //Gå til start
                goto Start;
            }
            if (input.Contains('+'))
            {
                Console.Clear();
                //Udregning af arrayet "tal1[0]" + "tal1[1]" [0] står for første tal og [1] står for andet tal
                double resultat = double.Parse(tal1[0]) + double.Parse(tal1[1]);
                //Der bliver rundet op via 2 tal systemet "resultat, 2"
                resultat = System.Math.Round(resultat, 2);
                //Udskrivning af arrayet og 2 strings "+", "=" og oprundingen
                Console.WriteLine(tal1[0] + "+" + tal1[1] + " = " + resultat);
                Console.ReadKey();
                Console.Clear();
                //Gå til start
                goto Start;
            }
            if (input.Contains('-'))
            {
                Console.Clear();
                //Udregning af arrayet "tal1[0]" - "tal1[1]" [0] står for første tal og [1] står for andet tal
                double resultat = double.Parse(tal1[0]) - double.Parse(tal1[1]);
                //Der bliver rundet op via 2 tal systemet "resultat, 2"
                resultat = System.Math.Round(resultat, 2);
                //Udskrivning af arrayet og 2 strings "-", "=" og oprundingen
                Console.WriteLine(tal1[0] + "-" + tal1[1] + " = " + resultat);
                Console.ReadKey();
                Console.Clear();
                //Gå til start
                goto Start;
            }
            if (input.Contains('*'))
            {
                Console.Clear();
                //Udregning af arrayet "tal1[0]" * "tal1[1]" [0] står for første tal og [1] står for andet tal
                double resultat = double.Parse(tal1[0]) * double.Parse(tal1[1]);
                //Der bliver rundet op via 2 tal systemet "resultat, 2"
                resultat = System.Math.Round(resultat, 2);
                //Udskrivning af arrayet og 2 strings "*", "=" og oprundingen
                Console.WriteLine(tal1[0] + "*" + tal1[1] + " = " + resultat);
                Console.ReadKey();
                Console.Clear();
                //Gå til start
                goto Start;
            }
            if (input.Contains('/'))
            {
                Console.Clear();
                //Udregning af arrayet "tal1[0]" / "tal1[1]" [0] står for første tal og [1] står for andet tal
                double resultat = double.Parse(tal1[0]) / double.Parse(tal1[1]);
                //Der bliver rundet op via 2 tal systemet "resultat, 2"
                resultat = System.Math.Round(resultat, 2);
                //Udskrivning af arrayet og 2 strings "/", "=" og oprundingen
                Console.WriteLine(tal1[0] + "/" + tal1[1] + " = " + resultat);
                Console.ReadKey();
                Console.Clear();
                //Gå til start
                goto Start;

            }
            Console.ReadKey();
            goto Start;
        }
    }
}
