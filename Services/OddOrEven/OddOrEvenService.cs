namespace HostingAllForOne.Services.OddOrEven;

public class OddOrEvenService : IOddOrEvenService
{
    public string OddOrEven(string number)
    {
        if (int.TryParse(number, out int num))
        {
            return (num % 2 == 0) ? $"The number {num} is an even number" : $"The number {num} is an odd number";
        }
        else
        {
            return $"ERROR, {number} is an invalid input, please enter in a whole number that isn't too big";
        }
    }
}
