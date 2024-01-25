
using HostingAllForOne.Services.ReverseItAlphanumeric;
using Microsoft.AspNetCore.Mvc;

namespace HostingAllForOne.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class ReverseItAlphanumericController : ControllerBase
    {
    private readonly IReverseItAlphanumericService _reverseItAlphanumericService;

    public ReverseItAlphanumericController(IReverseItAlphanumericService reverseItAlphanumericService)
    {
        _reverseItAlphanumericService = reverseItAlphanumericService;
    }

    [HttpGet]
        [Route("EnterAlphanumeric/{alphanumeric}")]
        public string ReverseIt(string alphanumeric){
            return _reverseItAlphanumericService.ReverseIt(alphanumeric);
        }
}
