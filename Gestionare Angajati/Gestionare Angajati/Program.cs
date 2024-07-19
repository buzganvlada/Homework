using System;
using System.Security.Cryptography.X509Certificates;

public class Angajat
{
    public string Nume { get; set; }
    public int Vechime { get; set; }
    public decimal Salariu { get; set; }

    public Angajat(string nume, int vechime, decimal salariu)
    {
        Nume = nume;
        Vechime = vechime;
        Salariu = salariu;
    }

    public virtual decimal CalculeazaSalariu()
    {
        if (Salariu >= 10000)
        {
            return Salariu;
        }
        else
        {
            throw new ArgumentOutOfRangeException("Salariul nu poate fi sub 10000");
        }
    }

    public class Manager : Angajat
    {
        public int Experienta { get; set; }

        public Manager(string nume, int vechime, decimal salariu, int experienta) : base(nume, vechime, salariu)
        {
            Experienta = experienta;
        }
        public override decimal CalculeazaSalariu()
        {
            return base.CalculeazaSalariu() + 0.30m * base.CalculeazaSalariu() * Experienta;
        }

    }
    public class Programator : Angajat
    {
        public List<string> Limbaje { get; set; }

        public Programator(string nume, int vechime, decimal salariu, List<string> limbaje)
            : base(nume, vechime, salariu)
        {
            Limbaje = limbaje;
        }

        public override decimal CalculeazaSalariu()
        {
            decimal salariu = base.CalculeazaSalariu();
            foreach (var limbaj in Limbaje)
            {
                if (limbaj == "C#")
                {
                    salariu += 4 * base.CalculeazaSalariu();
                }
                else
                {
                    salariu += 0.50m * base.CalculeazaSalariu();
                }
            }
            return salariu;
        }
    }
    public class Contabil : Angajat
    {
        public int Experienta { get; set; }

        public Contabil(string nume, int vechime, decimal salariu, int experienta)
            : base(nume, vechime, salariu)
        {
            Experienta = experienta;
        }

        public override decimal CalculeazaSalariu()
        {
            return base.CalculeazaSalariu() + 0.20m * base.CalculeazaSalariu() * Experienta;
        }
    }
}