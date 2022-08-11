using System.Linq;
public class Addition : ICalculable
{
    public decimal Calculate(decimal num1, decimal num2)
    {
        return num1 + num2;
    }
}