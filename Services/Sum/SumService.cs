namespace HostingAllForOne.Services.Sum;

public class SumService : ISumService
{
    public string Sum(string num1, string num2)
    {
        if(double.TryParse(num1, out double numOne) && double.TryParse(num2, out double numTwo))
        {
            return $"{numOne + numTwo}";
        } 
        else
        {
            return "Invalid Input(s)";
        }
    }
}
