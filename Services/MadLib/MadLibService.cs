namespace HostingAllForOne.Services.MadLib;

public class MadLibService : IMadLibService
{
    public string MadLib(string celebrityName, string animal, string bodyPart, string nounThatEndsWithS, string wholeNumberGreaterThan1, string time, string height, string adjective, string name, string condiment)
    {
        bool isInt = int.TryParse(wholeNumberGreaterThan1, out int num);
            if(isInt && num > 1){
                return $"THE FLASHBACK STORY:\nYou woke up at ({time}), with ({condiment}) smeared all over your ({bodyPart}). You soon realize that you need to go clean yourself up, but suddenly you notice that you fell asleep with ({celebrityName}) in your bed. You are so confused, so you try to remember what happened. You remember that you ran into a ({height}), ({adjective}) ({animal}) named ({name}) holding ({condiment}). ({name}) was the one who smeared ({condiment}) all over your ({bodyPart}) because you tried to eat ({name}).You also remember that ({celebrityName}) slept with you because you offered to give them ({num}) ({nounThatEndsWithS}) to sleep with you.";
            } else {
                return "ERROR, there was an invalid input, or you need to fill in all fields";
            }
    }
}
