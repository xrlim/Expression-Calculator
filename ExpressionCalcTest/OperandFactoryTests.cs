namespace ExpressionCalcTest;

public class ExpressionSolverTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void CalculateSimpleExpression()
    {
        // Arrange
        string expression = "1 + 1";
        ExpressionSolver expressionSolver = new();

        // Act
        var result = expressionSolver.Solve(expression);

        // Assert
        Assert.Pass("2", result);
    }

    [Test]
    public void CalculateWithBracketExpression()
    {
        // Arrange
        string expression = "(1 + 1)";
        ExpressionSolver expressionSolver = new();

        // Act
        var result = expressionSolver.Solve(expression);

        // Assert
        Assert.Pass("2", result);
    }

    [Test]
    public void CalculateNestedBracketExpression()
    {
        // Arrange
        string expression = "((1 + 1))";
        ExpressionSolver expressionSolver = new();

        // Act
        var result = expressionSolver.Solve(expression);

        // Assert
        Assert.Pass("2", result);
    }

    [Test]
    public void CalculateDoubleBracketExpression()
    {
        // Arrange
        string expression = "((1 + 1) + (1 + 1))";
        ExpressionSolver expressionSolver = new();

        // Act
        var result = expressionSolver.Solve(expression);

        // Assert
        Assert.Pass("2", result);
    }

    [Test]
    public void CalculateComplexExpression()
    {
        // Arrange
        string expression = "10 - ( 2 + 3 * ( 7 - 5 ) )";
        ExpressionSolver expressionSolver = new();

        // Act
        var result = expressionSolver.Solve(expression);

        // Assert
        Assert.Pass("2", result);
    }

    [Test]
    public void CalculateUntallyBracketExpression()
    {
        // Arrange
        string expression = "10 - ( 2 + 3 * ( 7 - 5  )";
        ExpressionSolver expressionSolver = new();

        // Act
        // Assert
        Assert.Throws<Exception>(() => expressionSolver.Solve(expression));
    }
}