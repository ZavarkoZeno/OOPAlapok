using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Szemely
    {
        protected string nev;
        private int kor;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set { kor = value; }
        }

        public override string ToString()
        {
            return $"A személy neve {nev} életkora {kor}";
        }

        public string Kiir()
        {
            return $"A tanuló neve: {nev} és {kor} éves.";
        }
    }

    public class Bankszamla
    {
        private int egyenleg;

        public int Egyenleg
        {
            get { return egyenleg; }
            set
            {
                if (value >= 0)
                    egyenleg = value;
                else
                    Console.WriteLine("Az érték nem lehet negatív.");
            }
        }
        public void Betesz()
        {

        }

        public void Kivesz()
        {

        }
    }

    public class Hallgato : Szemely
    {
        private int neptunkod;

        public void Kiir()
        {
            nev = string.Empty;
        }
        
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely();
            tanulo1.Nev = "Gábor";
            tanulo1.Kor = 23;

            Console.WriteLine(tanulo1);

            Bankszamla bankszamla1 = new Bankszamla();
            bankszamla1.Egyenleg = 5700;
            Console.WriteLine(bankszamla1.Egyenleg);
        }
    }
}
