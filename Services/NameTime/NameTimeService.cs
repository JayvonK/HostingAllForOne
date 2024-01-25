namespace HostingAllForOne.Services.NameTime;

public class NameTimeService : INameTimeService
{
    public string NT(string name, string time)
    {
        return $"Hello there user. Your name is {name}, nice to meet you. I can also see that you woke up at {time} today, cooooool.";
    }
}
