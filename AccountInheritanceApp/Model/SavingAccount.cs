using System;

namespace AccountInterfaceApp.Model
{
    public class SavingAccount : Account
    {
        private double _minimumBalance=500;

        public SavingAccount(int accNo, String accName, double balance) : base(accNo, accName, balance)
        {

        }
        public SavingAccount(int accNo, String accName):this(accNo,accName,500)
        {

        }

        public override void Withdrawl(int amount)
        {
            if (_balance - amount < _minimumBalance)
            {
                throw new Exception("Withdrawl unsuccessful.");
            }
            _balance -= amount;
        }
    }
}
