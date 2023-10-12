using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.WithoutPattern.Models
{
  public class WithoutPatternCustumer
  {
   

    private float _accountNumber;

    private string _address;

    private float _currentBalance;

    private string _currentBalanceStatus;

    private DateTime _dateofBirth;

    private string _fullName;


    public WithoutPatternCustumer(string firstName, string middleName, string lastname, float accountNumber, string address, string currentAccountStatus, float currentBalance, DateTime dateOdBirth)
    {
      _fullName = $"{lastname} {firstName} {middleName}";
      _accountNumber = accountNumber;
      _address = address;
      _currentBalance = currentBalance;
      _dateofBirth = dateOdBirth;
      _currentBalanceStatus = currentAccountStatus;

    }

    public OutPutCustumer Build()
    {
      return new OutPutCustumer()
      {
        DateofBirth = _dateofBirth,
        AccountNumber = _accountNumber,
        Address = _address,
        CurrentBalance = _currentBalance,
        CurrentBalanceStatus = _currentBalanceStatus,
        FullName = _fullName
      };
    }
  }
}
