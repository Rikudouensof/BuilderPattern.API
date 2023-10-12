using BuilderPattern.WithoutPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.WithoutPattern.Core
{
  public class WithoutPatternImplementation
  {

    public List<OutPutCustumer> GetCustumers()
    {
      var custumers = new List<OutPutCustumer>()
      {
        new WithoutPatternCustumer("Brigt",
        "White",
        "Corn",
        003003003,
        "12B Nebula cluster, Andromeda, Universe 1",
        "New to Bank",
        0,
        DateTime.Now.AddYears(-40)
        ).Build(),

        new WithoutPatternCustumer("Fresh",
        "Blue",
        "Berries",
        002002002,
        "Earth,Solar system,Near Orion Nebula cluster, Milky-way, Universe 1",
        "Owing is her culture",
        0,
        DateTime.Now.AddYears(-40)
        ).Build(),


      };
      return custumers;
    }







  }
}
