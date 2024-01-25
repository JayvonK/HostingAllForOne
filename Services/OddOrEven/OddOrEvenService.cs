namespace HostingAllForOne.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string number)
    {
        if (int.TryParse(number, out int num))
        {
            return (num % 2 == 0) ? "Even" : "Odd";
        }
        else
        {
            return $"Invalid Input";
        }
    }
}
