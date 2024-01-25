
using HostingAllForOne.Services.OddOrEven;
using Microsoft.AspNetCore.Mvc;

namespace HostingAllForOne.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class OddOrEvenController : ControllerBase
    {
    private readonly IOddOrEvenService _oddOrEvenService;

    public OddOrEvenController(IOddOrEvenService oddOrEvenService)
    {
        _oddOrEvenService = oddOrEvenService;
    }

    [HttpGet]
        [Route("EnterANumber/{number}")]
        public string OddOrEven(string number){
            return _oddOrEvenService.OddOrEven(number);
        }
}
