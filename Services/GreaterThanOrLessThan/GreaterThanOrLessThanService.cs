namespace HostingAllForOne.Services.GreaterThanOrLessThan;

public class GreaterThanOrLessThanService : IGreaterThanOrLessThanService
{
    public string GOrL(string numOne, string numTwo)
    {
        if (double.TryParse(numOne, out double num) && double.TryParse(numTwo, out double num2))
        {
            if (num > num2)
            {
                return $"{numOne}, is greater {numTwo}\n{numTwo}, is less than {numOne}";
            }
            else if (num < num2)
            {
                return $"{numOne}, is less than {numTwo}\n{numOne}, is less than {numTwo}";
            }
            else
            {
                return $"{numOne} & {numTwo} are equal";
            }
        }
        else
        {
            return "Error, you need to enter in numbers for both parameters.";
        }
    }
}
