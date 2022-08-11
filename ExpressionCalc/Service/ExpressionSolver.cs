using System.Linq;
using System.Text.RegularExpressions;

public class ExpressionSolver
{
    private readonly OperandFactory _operandFactory = new OperandFactory();

    private readonly int _bracketCount = 2; // open bracket + close bracket count

    public string Solve(string expression)
    {
        int openBracketCount = expression.Count(x => x == '(');
        int closeBracketCount = expression.Count(x => x == ')');

        if (openBracketCount != closeBracketCount)
        {
            throw new Exception("Open bracket doesn't tally with close bracket");
        }

        return SolveComplexExpression(expression);
    }

    public string SolveComplexExpression(string expression)
    {
        // Get the open bracket position
        int openBracketPosition = expression.LastIndexOf("(");
        // If open bracket not found
        if (openBracketPosition == -1)
        {
            return SolveExpression(expression).First();
        }
        string mostInnerExpression = expression.Substring(openBracketPosition + 1);
        int closeBracketPosition = mostInnerExpression.IndexOf(")");
        mostInnerExpression = mostInnerExpression.Substring(0, closeBracketPosition);

        var solvedExpression = SolveExpression(mostInnerExpression);
        // Replace the answer back to expression
        string finalExpression = expression.Substring(0, openBracketPosition) + solvedExpression.First() + expression.Substring(openBracketPosition + mostInnerExpression.Length + _bracketCount);
        return SolveComplexExpression(finalExpression);
    }

    public List<string> SolveExpression(string expression)
    {
        // sanitise the input
        expression = expression.TrimStart().TrimEnd();

        var expressionList = SplitExpressionBySpace(expression);
        List<string> solvedExpression = expressionList;
        foreach (char operand in _operandFactory.GetSupportedOperands())
        {
            solvedExpression = CalculateGenericExpressionListRecursively(solvedExpression, operand.ToString());
        }
        return solvedExpression;
    }

    /// <summary>
    /// This method will split the expression by space
    /// </summary>
    /// <param name="expression"></param>
    /// <returns></returns>
    public List<string> SplitExpressionBySpace(string expression)
    {
        return expression.Split(' ').ToList();
    }

    /// <summary>
    /// Solve the expression by recursively
    /// </summary>
    /// <param name="expressionList"></param>
    /// <param name="operand"></param>
    /// <returns></returns>
    public List<string> CalculateGenericExpressionListRecursively(List<string> expressionList, string operand)
    {
        int operandPosition = expressionList.FindIndex(x => x == operand);
        if (operandPosition == -1)
        {
            return expressionList;
        }
        var calculable = _operandFactory.GetCalculable(operand);
        decimal leftExpression = Convert.ToDecimal(expressionList[operandPosition - 1]);
        decimal rightExpression = Convert.ToDecimal(expressionList[operandPosition + 1]);

        var calculationResult = calculable.Calculate(leftExpression, rightExpression);
        expressionList[operandPosition] = calculationResult.ToString(); //Replace original opeand wih the calculated result        
        expressionList.RemoveAt(operandPosition + 1); //Remove the used expression
        expressionList.RemoveAt(operandPosition - 1); //Remove the used expression
        return CalculateGenericExpressionListRecursively(expressionList, operand);
    }



    public void CheckCalculationPrecedence(string expression)
    {
        if (expression.IndexOf("*") > 0)
        {

        }
    }

}