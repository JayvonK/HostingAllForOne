namespace HostingAllForOne.Services.Sum;

public class SumService : ISumService
{
    public string Sum(string num1, string num2)
    {
        if(int.TryParse(num1, out int numOne) && int.TryParse(num2, out int numTwo))
        {
            return $"The sum of {numOne} and {numTwo} is {numOne + numTwo}.";
        } 
        else
        {
            return "Invalid Input(s)";
        }
    }
}
