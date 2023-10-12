using BuilderPattern.ClasicBuilderPattern.Builders.IBuilder;
using BuilderPattern.ClasicBuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ClasicBuilderPattern.Builders.Builder
{
  public class GetCustumerBuilder : IGetCustumerBuilder
  {

    OutPutCustumer custumer = new OutPutCustumer();

    public void AddAccountNumber(float input)
    {
      custumer.AccountNumber = input;
    }

    public void AddDescription()
    {
      custumer.Description = $"The custumer {custumer.LastName} {custumer.FirstName} {custumer.MiddleName} has the account {custumer.AccountNumber}. \n Boy is this business broke? \n \b My CEO needs to talk to his village people \b";
    }

    public void AddFirstName(string input)
    {
      custumer.FirstName = input;
    }

    public void AddLastName(string input)
    {
      custumer.LastName = input;
    }

    public void AddMiddleName(string input)
    {
      custumer.MiddleName = input;
    }

    public OutPutCustumer Build()
    {
      return custumer;
    }
  }
}
