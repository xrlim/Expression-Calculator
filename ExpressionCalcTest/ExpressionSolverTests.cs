namespace ExpressionCalcTest;

public class OperandFactoryTests
{
    [SetUp]
    public void Setup()
    {

    }

    [Test]
    public void TestMultiplicationExpression()
    {
        decimal num1 = 2m;
        decimal num2 = 2m;
        decimal result = 4m;
        string operand = "*";
        OperandFactory operandFactory = new OperandFactory();
        var calculable = operandFactory.GetCalculable(operand);

        var output = calculable.Calculate(num1, num2);
        Assert.That(output, Is.EqualTo(result));
    }

    [Test]
    public void TestDivideExpression()
    {
        decimal num1 = 2m;
        decimal num2 = 2m;
        decimal result = 1m;
        string operand = "/";
        OperandFactory operandFactory = new OperandFactory();
        var calculable = operandFactory.GetCalculable(operand);

        var output = calculable.Calculate(num1, num2);
        Assert.That(output, Is.EqualTo(result));
    }

    [Test]
    public void TestPlusExpression()
    {
        decimal num1 = 2m;
        decimal num2 = 2m;
        decimal result = 4m;
        string operand = "+";
        OperandFactory operandFactory = new OperandFactory();
        var calculable = operandFactory.GetCalculable(operand);

        var output = calculable.Calculate(num1, num2);
        Assert.That(output, Is.EqualTo(result));
    }

    [Test]
    public void TestMinusExpression()
    {
        decimal num1 = 2m;
        decimal num2 = 2m;
        decimal result = 0m;
        string operand = "-";
        OperandFactory operandFactory = new OperandFactory();
        var calculable = operandFactory.GetCalculable(operand);

        var output = calculable.Calculate(num1, num2);
        Assert.That(output, Is.EqualTo(result));
    }
}