namespace HostingAllForOne.Services.GreaterThanOrLessThan;

public class GreaterThanOrLessThanService : IGreaterThanOrLessThanService
{
    public string GOrL(string numOne, string numTwo)
    {
        if (double.TryParse(numOne, out double num) && double.TryParse(numTwo, out double num2))
        {
            if (num > num2)
            {
                return $"The first number: {numOne}, is greater than the second number: {numTwo}. \nThe second number: {numTwo}, is less than the first number: {numOne}.";
            }
            else if (num < num2)
            {
                return $"The first number: {numOne}, is less than the second number: {numTwo}. \nThe second number: {numTwo}, is greater than the first number: {numOne}.";
            }
            else
            {
                return $"The first number: {numOne}, is equal to the second number: {numTwo}. \nThe second number: {numTwo}, is equal to the first number: {numOne}.";
            }
        }
        else
        {
            return "Error, you need to enter in numbers for both parameters.";
        }
    }
}
