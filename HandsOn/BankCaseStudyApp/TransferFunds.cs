using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankCaseStudyApp
{
    public class TransferFunds
    {
        public void TransferAmount(SavingsAccount from , SavingsAccount dest, double amount, int pin)
        {
            if (!from.Active)
                throw new AccountAlreadyClosedException("Your Account is Inactive..");
            if (!dest.Active)
                throw new AccountAlreadyClosedException("Destination Account is Inactive..");

            // If statements for checking pay limit

            from.Withdraw(amount, pin);
            dest.Deposit(amount);

        }
    }
}
