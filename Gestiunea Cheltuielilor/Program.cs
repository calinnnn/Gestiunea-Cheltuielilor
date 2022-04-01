using System;
using System.Configuration;
using System.IO;



namespace Gestiunea_Cheltuielilor
{
    class Program
    {
        private Stream fisier_venituri;

        static void Main()
        {
            int v = 0;
            int Venituri = 0;
            int c = 0;
            int Cheltuieli = 0; 
            string optiune;
            do
            {
                Console.WriteLine("A. Introduceti Veniturile: ");
                Console.WriteLine("S. Salvare Venituri");
                Console.WriteLine("D. Afisare Venituri");
                Console.WriteLine("G. Salvare Cheltuieli");
                Console.WriteLine("H. Afisare Cheltuieli");
                Console.WriteLine("X. Inchidere program");
                Console.WriteLine("Alegeti o optiune");
                optiune = Console.ReadLine();
                switch (optiune.ToUpper())
                {
                    case "A":

                        CitireVenituri(Venituri, v);
                        v = int.Parse(Console.ReadLine());

                        break;
                    case "S":


                        break;

                    case "D":

                        Console.WriteLine("Veniturile sunt :" + v);

                        break;
                   
                    case "G":


                        break;
                    case "H":
                        CitireCheltuieli(Cheltuieli, c);
                        c = int.Parse(Console.ReadLine());
                        Console.WriteLine("CAS si CASS sunt :" +(v*35)/100 );
                        Console.WriteLine("Impozitele la stat sunt :" + (v*10) / 100);
                        Console.WriteLine("Cheltuielile diverse sunt :" + (v*25) / 100);
                        break;
                    case "X":

                        return;

                        break;

                }
            }
            while (optiune.ToUpper() != "X");

            Console.ReadKey();


        }

        public static void CitireVenituri(int v, int Venituri)
        {

            for (v = 0; v > 0; v++)
            {
                Console.WriteLine("Veniturile sunt:");

                //v = int.Parse(Console.ReadLine());
                //Console.WriteLine("v=" +v);


            }
        }
        public static void CitireCheltuieli(int c, int Cheltuieli)
        {

            for (c = 0; c > 0; c++)
            {
                Console.WriteLine("Cheltuielile sunt:");

                //c = int.Parse(Console.ReadLine());
                //Console.WriteLine("c=" +c);


            }
        }
    }
}

        //public class AdministrareDate_FisierText
       // {
            //private string fisier_venituri;
           // int v = 0;
            //public AdministrareDate_FisierText(string fisier_venituri)
            //{
                //this.fisier_venituri = fisier_venituri;
                //Stream streamFisierText = File.Open(fisier_venituri, FileMode.OpenOrCreate);
                //streamFisierText.Close();
           // }

           // public void AddVenituri(Venituri v)
            //{
                //using (StreamWriter streamWriterFisierText = new StreamWriter(fisier_venituri, true))
                //{ }
           // }
        //}
   // }
//}

        //public Venituri[] GetVenituri(out int v)

        //{ Venituri() =  new Venituri[100];

            //using (StreamReader streamReader = new StreamReader(fisier_venituri))
            //{
                //string linieFisier;
                //const int V = 0;
                //v = V;

               // while ((linieFisier = streamReader.ReadLine()) != null)

//}               //{
               // Venituri[100] = new Venituri( string linieFisier); } } 
                // return V; 


