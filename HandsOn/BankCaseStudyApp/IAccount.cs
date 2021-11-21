using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public interface IAccount
    {
        bool Open();
        bool Close();
        void SetAccNo(string accNo);
        string GetAccNo();
        void SetName(string name);
        string GetName();
        void SetPin(int pin);
      //  int GetPin();

        void SetActive(bool active);
        bool IsActive();








    }
}
