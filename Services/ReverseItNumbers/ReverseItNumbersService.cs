namespace HostingAllForOne.Services.ReverseItNumbers;

    public class ReverseItNumbersService : IReverseItNumbersService
    {
        public string ReversedNumber(string number)
        {
            string reversed = "";
            if (double.TryParse(number, out double num))
            {
                for (int i = number.Length - 1; i >= 0; i--)
                {
                    reversed += number[i];
                }
                return $"{reversed}";
            }
            else
            {
                return "Invalid input";
            }
        }
    }
