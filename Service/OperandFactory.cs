public class OperandFactory
{
    public ICalculable GetCalculable(string operand)
    {
        string operandTrim = operand.Trim();
        switch (operandTrim)
        {
            case "+":
                return new Addition();
            case "-":
                return new Minus();
            case "*":
                return new Multiply();
            case "/":
                return new Divide();
            default:
                throw new NotSupportedException("New kind of operand detected! Please enhance your operand factory");
        }
    }
}