using HostingAllForOne.Services.Sum;
using Microsoft.AspNetCore.Mvc;

namespace HostingAllForOne.Controllers;

[ApiController]
[Route("[controller]")]

public class SumController : ControllerBase
{
    private readonly ISumService _sumService;

    public SumController(ISumService sumService)
    {
        _sumService = sumService;
    }

    [HttpGet]
    [Route("EnterTwoNumbers/{firstNumber}/{secondNumber}")]
    public string AddTwoNumbers(string firstNumber, string secondNumber)
    {
        return _sumService.Sum(firstNumber, secondNumber);
    }
}
