using Microsoft.AspNetCore.Mvc;
using MiniChallengeEightToTen_Endpoints.Services.EightBall;

namespace HostingAllForOne.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class EightBallController : ControllerBase
    {
    private readonly IEightBallService _eightBallService;

    public EightBallController(IEightBallService eightBallService)
    {
        _eightBallService = eightBallService;
    }

    
}
