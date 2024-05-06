using AljabarLibraries;
using System;

class Program
{
    static void Main(string[] args)
    {
        Aljabar calculator = new Aljabar();

        double[] akar = calculator.AkarPersamaanKuadrat([1, -3, -10]);
        Console.WriteLine("Akar Persamaan kuadrat dari (1, -3, -10): " + akar[0] + ", " + akar[1]);

        double[] hasilKuadrat = calculator.HasilKuadrat([2, -3]);
        Console.WriteLine("Hasil kuadrat persamaan (2, -3): " + hasilKuadrat[0]);
    }   
}