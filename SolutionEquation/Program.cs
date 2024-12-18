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

        if (a == 0)
        {
            Console.WriteLine("La valeur de 'a' ne peut pas être zéro pour une équation quadratique.");
        }
        else
        {
            List<double> solutions = solution.SolveQuadraticEquation(a, b, c);

            if (solutions.Count == 0)
            {
                Console.WriteLine("L'équation n'a pas de solutions réelles.");
            }
            else if (solutions.Count == 1)
            {
                Console.WriteLine($"L'équation a une solution réelle : x = {solutions[0]}");
            }
            else
            {
                Console.WriteLine($"L'équation a deux solutions réelles : x1 = {solutions[0]}, x2 = {solutions[1]}");
            }
        }
    }
}
