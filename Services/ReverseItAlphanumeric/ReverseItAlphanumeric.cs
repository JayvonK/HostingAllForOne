namespace HostingAllForOne.Services.ReverseItAlphanumeric;
public class ReverseItAlphanumeric : IReverseItAlphanumericService
{
    public string ReverseIt(string alphanumeric)
    {
        string reversed = "";
            for(int i = alphanumeric.Length - 1; i >= 0; i--){
                reversed += alphanumeric[i];
            }
            return reversed;
    }
}
