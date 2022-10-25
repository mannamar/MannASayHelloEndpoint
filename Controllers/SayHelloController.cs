// Amardeep Mann
// 10-25-22
// SayHello Endpoint
// Added the ability to take in an input via web URL for our SayHello function
// Peer reviewed by Arely: Amar has made a default string that pops up regardless if the user enter a input after the route name. Which hasn’t been taught yet so he had to go out of his way to learn this. Additionally, Amar has easy to understand name convention with the controller and route name. Overall great job and a lot of effort put in to get ahead.

using Microsoft.AspNetCore.Mvc;

namespace MannASayHelloEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class SayHelloController : ControllerBase
{
  [HttpGet]
  public string SayHelloDefault()
  {
    return $"Hello you handsome devil!";
  }

  [HttpGet]
  [Route("{name}")]
  public string SayHello(string name = "you beautifule son of a gun")
  {
    return $"Hello {name}!";
  }
}
