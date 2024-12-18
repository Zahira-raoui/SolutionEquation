namespace SolutionEquation.nUnitTest
{
    public class Tests
    {

        private Solution _solutionEquation { get; set; } = null!;

        [SetUp]
        public void Setup()
        {
            _solutionEquation = new Solution();

        }

        [Test]
        public void TestSolution_Equation2degre()
        {
            // Résoudre l'équation x² - 3x + 2 = 0
            var solutions = _solutionEquation.SolveQuadraticEquation(1, -3, 2);

            // Vérifier que deux solutions existent
            Assert.AreEqual(2, solutions.Count);

            // Vérifier les valeurs des solutions
            Assert.Contains(2, solutions); // Une solution est x1 = 2
            Assert.Contains(1, solutions); // Une autre solution est x2 = 1
        }

        [Test]
        public void TestSolution_EquationPasDeSolution()
        {
            // Résoudre une équation sans solution réelle
            var solutions = _solutionEquation.SolveQuadraticEquation(1, 0, 1);

            // Vérifier qu'il n'y a pas de solutions
            Assert.AreEqual(0, solutions.Count);
        }
    }
}