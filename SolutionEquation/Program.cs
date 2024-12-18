// Fichier Program.cs
using SolutionEquation;

class Program
{
    static void Main(string[] args)
    {
        Solution solution = new Solution();

        Console.Write("Entrez la valeur de a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez la valeur de b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Entrez la valeur de c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        solution.SolveQuadraticEquation(a, b, c);
    }
}
