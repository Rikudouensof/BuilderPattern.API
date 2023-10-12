using BuilderPattern.ClasicBuilderPattern.Builders.Core;
using BuilderPattern.Normal.Core;
using BuilderPattern.WithoutPattern.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuilderPattern.API.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class BuilderController : ControllerBase
  {

    [HttpGet("normal")]
    public IActionResult GetCustumersNormal()
    {

      var custumers = new NormalImplementation().GetCustumers();
      return Ok(custumers);
    }


    [HttpGet("withoutPattern")]
    public IActionResult GetCustumersWithoutPattern()
    {

      var custumers = new WithoutPatternImplementation().GetCustumers();
      return Ok(custumers);
    }

    [HttpGet("ClasicBuilder")]
    public IActionResult GetCustumer()
    {
      var custumer = new ClasicBuilderImplementation().GetCustumer();
      return Ok(custumer);
    }


  }
}
