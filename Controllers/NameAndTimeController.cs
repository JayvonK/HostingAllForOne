
using HostingAllForOne.Services.NameTime;
using Microsoft.AspNetCore.Mvc;

namespace HostingAllForOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NameAndTimeController : ControllerBase
    {
        private readonly INameTimeService _nameTimeService;

        public NameAndTimeController(INameTimeService nameTimeService)
        {
            _nameTimeService = nameTimeService;
        }

        [HttpGet]
        [Route("EnterYourName/{yourName}/EnterTimeYouWokeUp/{timeYouWokeUp}")]

        public string NameAndTime(string yourName, string timeYouWokeUp)
        {
            return _nameTimeService.NT(yourName, timeYouWokeUp);
        }
    }
}