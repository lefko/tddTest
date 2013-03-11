using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tddTest
{
    class Program
    {
        static void Main(string[] args)
        {
             Konto mittKonto;
            mittKonto = new Konto();

            mittKonto.SetKontoNummer("123456");
            mittKonto.Insattning(8000);
            // double saldot = mittKonto.SaldoBesked();

            Console.WriteLine();
            Console.WriteLine("--------------- Konto: {0}--------------------------- \n", mittKonto.GetKontoNummer());
            Console.WriteLine(mittKonto.SaldoBesked());

            bool ut;
            ut = mittKonto.Uttag(3000);
            Console.WriteLine("Ditt Saldo på kontot är nu {0} SEK", mittKonto.SaldoBesked());
            Console.WriteLine("Gick det att ta ut pengar?" + ut);
            Console.WriteLine("Nu finns det " + mittKonto.SaldoBesked());
            Console.WriteLine();
            

            Konto mittKonto2;
            mittKonto2 = new Konto();

            mittKonto2.SetKontoNummer("23452176");
            mittKonto2.Insattning(8000);
            Console.WriteLine("--------------- Konto 2: {0} -------------------------- \n", mittKonto2.GetKontoNummer());
            Console.WriteLine("Ditt Saldo på kontot är nu {0} SEK", mittKonto2.SaldoBesked());

            bool ut2;
            ut2 = mittKonto2.Uttag(9000);
            Console.WriteLine("Gåre det att ta ut pengar? {0}", ut2);
            Console.WriteLine("Ditt Saldo på kontot är nu {0} SEK", mittKonto2.SaldoBesked());



            Console.ReadLine();

            #region Egna tester

            //double insattning = AddFunds();
            //mittKonto.Insattning(insattning);
            //Console.WriteLine(mittKonto.SaldoBesked());

            //Console.ReadLine();

            #endregion

        }

        #region Egna tester

        //public static double AddFunds()
        //{
        //    Console.Write("Hur mycket vill du sätta in?");
        //    double addMoney = double.Parse(Console.ReadLine());
        //    return addMoney;
        //}

        #endregion
        }
    }
