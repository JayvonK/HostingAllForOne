namespace HostingAllForOne.Services.SayHello;

public class SayHellosService : ISayHelloService
{
    public List<string> greet = new();
    public Random randNum = new();

    public string greeter = "";

    public SayHellosService()
    {
        greet.Add("Hello, ");
        greet.Add("Hi, ");
        greet.Add("Greetings, ");
        greet.Add("Howdy, ");
        greet.Add("Hola, ");
        greet.Add("What's up, ");
        greet.Add("Hi(with fist bump), ");

        int rng = randNum.Next(0, greet.Count);
        greeter = greet[rng];
    }

    public string Hello(string name)
    {
        return greeter + name;
    }
}
