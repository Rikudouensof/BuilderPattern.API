using BuilderPattern.Normal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.Normal.Core
{
  public class NormalImplementation
  {


    public List<NormalCustumer> GetCustumers()
    {
      var custumers = new List<NormalCustumer>()
      {
        new NormalCustumer()
        {
          FirstName = "Brigt",
          MiddleName = "White",
          LastName = "Corn",
          AccountNumber = 003003003,
          Address = "12B Nebula cluster, Andromeda, Universe 1",
          CurrentBalance = 0,
          DateofBirth = DateTime.Now.AddYears(-40),
          CurrentBalanceStatus = "New to Bank"
        },
        new NormalCustumer()
        {
          FirstName = "Fresh",
          MiddleName = "Blue",
          LastName = "Berries",
          AccountNumber = 002002002,
          Address = "Earth,Solar system,Near Orion Nebula cluster, Milky-way, Universe 1",
          CurrentBalance = -3200000,
          DateofBirth = DateTime.Now.AddYears(-20),
          CurrentBalanceStatus = "Owing is her culture"
        },
        new NormalCustumer()
        {
          FirstName = "Fresh",
          MiddleName = "Blue",
          LastName = "Currents",
          AccountNumber = 002002002,
          Address = "Earth,Solar system,Near Orion Nebula cluster, Milky-way, Universe 1",
          CurrentBalance = 70000000,
          DateofBirth = DateTime.Now.AddYears(-70),
          CurrentBalanceStatus = "good"
        },
        new NormalCustumer()
        {
          FirstName = "Brigt",
          MiddleName = "Yellow",
          LastName = "Corn",
          AccountNumber = 003003003,
          Address = "12B Nebula cluster, Andromeda, Universe 1",
          CurrentBalance = 0,
          DateofBirth = DateTime.Now.AddYears(-40),
          CurrentBalanceStatus = "New to Bank like his twin"
        }
      };

      return custumers;
    }
  }
}
