using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tddTest
{
    public class Konto
    {

        // Deklaration av medlemsattribut

        private string kontoNummer;
        private double saldo;

        public bool Uttag(double belopp)
        {
            if (belopp <= saldo)
            {
                saldo -= belopp;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Insattning(double belopp)
        {
            saldo += belopp;
        }

        public double SaldoBesked()
        {
            return saldo; //Skicka tillbaka en kopia av innehållet i saldo.
        }

        public void SetKontoNummer(string knr)
        {
            kontoNummer = knr;
        }

        public string GetKontoNummer()
        {
            return kontoNummer;
        }
    }
}
