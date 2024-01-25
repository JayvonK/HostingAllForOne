
using HostingAllForOne.Services.MadLib;
using Microsoft.AspNetCore.Mvc;

namespace HostingAllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class MadLibController : ControllerBase
{
    private readonly IMadLibService _madLibService;

    public MadLibController(IMadLibService madLibService)
    {
        _madLibService = madLibService;
    }

    [HttpGet]
    [Route("EnterCelebrityName/{celebrityName}/EnterAnimal/{animal}/EnterBodyPart/{bodyPart}/EnterNounThatEndsWithS/{nounThatEndsWithS}/EnterWholeNumberGreaterThan1/{wholeNumberGreaterThan1}/EnterTime/{time}/EnterHeight/{height}/EnterAdjective/{adjective}/EnterName/{name}/EnterCondiment/{condiment}")]
    public string MadLib(string celebrityName, string animal, string bodyPart, string nounThatEndsWithS, string wholeNumberGreaterThan1, string time, string height, string adjective, string name, string condiment)
    {
        return _madLibService.MadLib(celebrityName, animal, bodyPart, nounThatEndsWithS, wholeNumberGreaterThan1, time, height, adjective, name, condiment);
    }
}
