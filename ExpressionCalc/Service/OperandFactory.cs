public class OperandFactory
{
    // Order is important
    private readonly char[] _supportedDelimiters = { '*', '/','-' , '+'};
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

    /// <summary>
    /// Get list of supported operators order by precedence
    /// </summary>
    /// <returns></returns>
    public char[] GetSupportedOperands()
    {
        return _supportedDelimiters;
    }
    
}