namespace AljabarLibraries
{
    public class Aljabar
    {
        public static double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double D = b * b - 4 * a * c; // Diskriminan

            // Menghitung akar-akar
            double akar1 = (-b + Math.Sqrt(D)) / (2 * a);
            double akar2 = (-b - Math.Sqrt(D)) / (2 * a);

            return new double[] { akar1, akar2 };
        }

        public static double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            // Menghitung hasil kuadrat
            double a2 = a * a;
            double b2 = b * b;
            double ab = 2 * a * b;

            return new double[] { a2, ab, b2 };
        }
    }
}
