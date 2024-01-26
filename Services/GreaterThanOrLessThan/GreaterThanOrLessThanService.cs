namespace HostingAllForOne.Services.GreaterThanOrLessThan;

public class GreaterThanOrLessThanService : IGreaterThanOrLessThanService
{
    public string GOrL(string numOne, string numTwo)
    {
        if (double.TryParse(numOne, out double num) && double.TryParse(numTwo, out double num2))
        {
            if (num > num2)
            {
                return ">";
            }
            else if (num < num2)
            {
                return "<";
            }
            else
            {
                return "=";
            }
        }
        else
        {
            return "Invalid Input(s)";
        }
    }
}
