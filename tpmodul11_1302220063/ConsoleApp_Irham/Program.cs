using System;
using AljabarLibraries;

class Program
{
    static void Main(string[] args)
    {
        // Ambil input persamaan kuadrat dari pengguna
        Console.WriteLine("\nMasukkan koefisien persamaan kuadrat (a, b, dan c) dipisahkan dengan spasi:");
        string inputKuadrat = Console.ReadLine();
        string[] koefisienKuadrat = inputKuadrat.Split(' ');

        // Parsing input ke dalam bentuk double[]
        double aKuadrat = Convert.ToDouble(koefisienKuadrat[0]);
        double bKuadrat = Convert.ToDouble(koefisienKuadrat[1]);
        double cKuadrat = Convert.ToDouble(koefisienKuadrat[2]);
        double[] persamaanKuadrat = { aKuadrat, bKuadrat, cKuadrat };

        // Panggil fungsi AkarPersamaanKuadrat dari AljabarLibraries
        double[] akar = Aljabar.AkarPersamaanKuadrat(persamaanKuadrat);
        Console.WriteLine($"Akar-akar dari persamaan {aKuadrat}x^2 + {bKuadrat}x + {cKuadrat}:");
        Console.WriteLine($"{akar[0]}, {akar[1]}");

        // Ambil input persamaan linear dari pengguna
        Console.WriteLine("Masukkan koefisien persamaan linear (a dan b) dipisahkan dengan spasi:");
        string inputLinear = Console.ReadLine();
        string[] koefisienLinear = inputLinear.Split(' ');

        // Parsing input ke dalam bentuk double[]
        double aLinear = Convert.ToDouble(koefisienLinear[0]);
        double bLinear = Convert.ToDouble(koefisienLinear[1]);
        double[] persamaanLinear = { aLinear, bLinear };

        // Panggil fungsi HasilKuadrat dari AljabarLibraries
        double[] hasilKuadrat = Aljabar.HasilKuadrat(persamaanLinear);
        Console.WriteLine($"Hasil kuadrat dari persamaan {aLinear}x + {bLinear}:");
        Console.WriteLine($"{hasilKuadrat[0]},{hasilKuadrat[1]},{hasilKuadrat[2]}");
    }
}
