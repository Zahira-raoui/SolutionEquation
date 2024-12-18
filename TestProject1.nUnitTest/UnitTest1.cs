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
            // R�soudre l'�quation x� - 3x + 2 = 0
            var solutions = _solutionEquation.SolveQuadraticEquation(1, -3, 2);

            // V�rifier que deux solutions existent
            Assert.AreEqual(2, solutions.Count);

            // V�rifier les valeurs des solutions
            Assert.Contains(2, solutions); // Une solution est x1 = 2
            Assert.Contains(1, solutions); // Une autre solution est x2 = 1
        }

        [Test]
        public void TestSolution_EquationPasDeSolution()
        {
            // R�soudre une �quation sans solution r�elle
            var solutions = _solutionEquation.SolveQuadraticEquation(1, 0, 1);

            // V�rifier qu'il n'y a pas de solutions
            Assert.AreEqual(0, solutions.Count);
        }
    }
}