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
