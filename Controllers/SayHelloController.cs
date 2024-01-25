using HostingAllForOne.Services.SayHello;
using Microsoft.AspNetCore.Mvc;

namespace HostingAllForOne.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
    private readonly ISayHelloService _sayHelloService;

    public SayHelloController(ISayHelloService sayHelloService)
        {
        _sayHelloService = sayHelloService;
    }
        
    [HttpGet]
    [Route("Greeting/{name}")]
    public string Hello(string name)
    {
        return _sayHelloService.Hello(name);
    }
    }
