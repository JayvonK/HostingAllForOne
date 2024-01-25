using HostingAllForOne.Services.GreaterThanOrLessThan;
using Microsoft.AspNetCore.Mvc;

namespace HostingAllForOne.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterOrLessThanController : ControllerBase
{
    private readonly IGreaterThanOrLessThanService _greaterThanOrLessThanService;

    public GreaterOrLessThanController(IGreaterThanOrLessThanService greaterThanOrLessThanService)
    {
        _greaterThanOrLessThanService = greaterThanOrLessThanService;
    }

    [HttpGet]
    [Route("EnterTwoNumbers/{firstNumber}/{secondNumber}")]
    public string GreaterOrLess(string firstNumber, string secondNumber)
    {
        return _greaterThanOrLessThanService.GOrL(firstNumber, secondNumber);
    }
}
