using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolutionEquation
{
    public class Solution
    {
        public List<double> SolveQuadraticEquation(double a, double b, double c)
        {
            List<double> solutions = new List<double>();

            double discriminant = b * b - 4 * a * c;

            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                solutions.Add(x1);
                solutions.Add(x2);
            }
            else if (discriminant == 0)
            {
                double x = -b / (2 * a);
                solutions.Add(x);
            }
            // Si le discriminant est négatif, aucune solution réelle
            return solutions;
        }
    }
}
