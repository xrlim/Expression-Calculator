// See https://aka.ms/new-console-template for more information
string expression = string.Empty;
string result = string.Empty;
ExpressionSolver expressionParser = new ExpressionSolver();

Console.WriteLine("\nYour code must return the correct result for: ");
expression = "1 + 1";
ShowResult(expression);

expression = "2 * 2";
ShowResult(expression);

expression = "1 + 2 + 3";
ShowResult(expression);

expression = "6 / 2";
ShowResult(expression);

expression = "11 + 23";
ShowResult(expression);

expression = "11.1 + 23";
ShowResult(expression);

expression = "1 + 1 + 3";
ShowResult(expression);

Console.WriteLine("\nYour solution should ideally also handle brackets and provide the correct result for:");
expression = "( 11.5 + 15.4 ) + 10.1";
ShowResult(expression);

expression = "23 - ( 29.3 - 12.5 )";
ShowResult(expression);

expression = "( 1 / 2 ) - 1 + 1";
ShowResult(expression);

Console.WriteLine("\nHandling of nested brackets and other additional features not stated above would be considered a bonus: ");
expression = "10 - ( 2 + 3 * ( 7 - 5 ) )";
ShowResult(expression);

Console.ReadLine();

void ShowResult(string expression)
{
    var result = expressionParser.Solve(expression);
    Console.WriteLine($"{expression} = {result}");
}