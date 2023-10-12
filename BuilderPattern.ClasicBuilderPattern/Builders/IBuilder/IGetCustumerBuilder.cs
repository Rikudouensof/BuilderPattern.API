using BuilderPattern.ClasicBuilderPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.ClasicBuilderPattern.Builders.IBuilder
{
  public interface IGetCustumerBuilder
  {

    void AddFirstName(string input);

    void AddMiddleName(string input);

    void AddLastName(string input);

    void AddAccountNumber(float input);

    void AddDescription();

    OutPutCustumer Build();


  }
}
