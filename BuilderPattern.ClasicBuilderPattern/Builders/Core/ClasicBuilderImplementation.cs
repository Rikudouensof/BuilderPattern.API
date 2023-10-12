using BuilderPattern.ClasicBuilderPattern.Builders.Builder;
using BuilderPattern.ClasicBuilderPattern.Builders.IBuilder;
using BuilderPattern.ClasicBuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ClasicBuilderPattern.Builders.Core
{
  public class ClasicBuilderImplementation
  {


    public OutPutCustumer GetCustumer()
    {
      var builder =  new GetCustumerBuilder();
      builder.AddFirstName("Own");
      builder.AddLastName("Ains");
      builder.AddMiddleName("Gown");
      builder.AddAccountNumber(00080008900);
      builder.AddDescription();
      
      return builder.Build();

    }
  }
}
