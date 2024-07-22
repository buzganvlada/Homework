using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var mathOperations = new MathOperations<int>();

        int a = 14;
        int b = 7;

        Console.WriteLine($"Adunarea numerelor 14 si 7: {mathOperations.Add(a, b)}");
        Console.WriteLine($"Scaderea numerelor 14 si 7: {mathOperations.Substract(a, b)}");
        Console.WriteLine($"Inmultirea numerelor 14 si 7: {mathOperations.Multiply(a, b)}");
        Console.WriteLine($"Impartirea numerelor 14 si 7: {mathOperations.Divide(a,b)}");

        var mathOperationsDouble = new MathOperations<double>();

        double aDouble = 9.5;
        double bDouble = 15.3;

        Console.WriteLine($"Adunarea numerelor 9.5 si 15.3: {mathOperationsDouble.Add(aDouble, bDouble)}");
        Console.WriteLine($"Scaderea numerelor 9.5 si 15.3: {mathOperationsDouble.Substract(aDouble, bDouble)}");
        Console.WriteLine($"Inmultirea numerelor 9.5 si 15.3: {mathOperationsDouble.Multiply(aDouble, bDouble)}");
        Console.WriteLine($"Impartirea numerelor 9.5 si 15.3: {mathOperationsDouble.Divide(aDouble, bDouble)}");
    }
}