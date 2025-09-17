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

        public Szemely(string name, int age)
        {
            nev = name;
            kor = age;
        }

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
        private string neptunkod;

        public Hallgato(string name, int age, string neptuncode) : base(name, age)
        {
            neptunkod = neptuncode;
        }

        public string NeptunKod
        {
            get { return neptunkod; }
            set
            {
                if (value.Length <= 6)
                    neptunkod = value;
                else
                    Console.WriteLine("Nem megfelelő hosszúság.");
            }
        }

        public override string ToString()
        {
            return $"A hallgató neve {nev}";
        }
        
    }

    public class Dolgozo : Szemely
    {
        private int ber;

        public Dolgozo(string name, int age, int salary) : base(name, age)
        {
            ber = salary;
        }

        public override string ToString()
        {
            return $"A hallgató neve {nev} a bére {ber}
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

            Hallgato hallgato1 = new Hallgato();
            hallgato1.NeptunKod = "MHWLN99";
            Console.WriteLine(hallgato1.NeptunKod);
            List<Hallgato> hallgatok = new List<Hallgato>();

            for (int i = 0; i < 2; i++)
            {
                Hallgato hallgato = new Hallgato();
                Console.Write($"Kérem a(z) {i + 1} hallgató nevét");
                hallgato.Nev = Console.ReadLine();
                Console.Write($"Kérem a(z) {i + 1} hallgató életkorát");
                hallgato.Kor = int.Parse(Console.ReadLine() );
                Console.Write($"Kérem a(z) {i + 1} hallgató neptunkódját");
                hallgato.NeptunKod = Console.ReadLine();
                hallgatok.Add( hallgato );
            }
            foreach (var item in hallgatok)
            {
                Console.WriteLine($"A hallgatók neve: {item.Nev}");
            }

            Hallgato hallgato1 = new Hallgato("Peti", 22, "MHWLN9");
            Console.WriteLine(hallgato1);

            Dolgozo dolgozo1 = new Dolgozo("Gábor", 43, 75000);
        }
    }
}
