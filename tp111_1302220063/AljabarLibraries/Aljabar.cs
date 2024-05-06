namespace AljabarLibraries
{
    public class Aljabar
    {
        public double[] AkarPersamaanKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];
            double c = persamaan[2];

            double[] roots;

            double diecriminant = b * b - 4 * a * c;

            if (diecriminant > 0)
            {
                double root1 = (-b + Math.Sqrt(diecriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(diecriminant)) / (2 * a);

                roots = new double[] { root1, root2 };
            }
            else if (diecriminant == 0)
            {
                double root = -b / (2 * a);
                roots = new double[] { root, root };
            }
            else
            {
                roots = new double[0];
            }
            return roots;
        }
        public double[] HasilKuadrat(double[] persamaan)
        {
            double a = persamaan[0];
            double b = persamaan[1];

            return new double[] { (a * a) + (2 * a * b) + (b * b) };
        }
    }
}
