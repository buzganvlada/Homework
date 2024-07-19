using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Angajat;

class Program
{
    static void Main(string[] args)
    {
        List<Angajat> angajati = new List<Angajat>
        {
            new Manager("Ana", 10, 10000, 5),
            new Programator("Danu", 8, 10000, new List<string> { "C#", "Java" }),
            new Contabil("Gabriela", 15, 10000, 10)
        };

        foreach (var angajat in angajati)
        {
            Console.WriteLine($"Nume: {angajat.Nume}, Salariu: {angajat.CalculeazaSalariu()}");
        }
    }
}
