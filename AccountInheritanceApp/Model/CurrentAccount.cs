using System;

namespace AccountInterfaceApp.Model
{
    public class CurrentAccount:Account
    {
        private double _minimumBalance = 1000;

        public CurrentAccount(int accNo, String accName, double balance):base(accNo,accName,balance)
        {
            
        }
        public CurrentAccount(int accNo, String accName) : this(accNo, accName, 500)
        {

        }

        public override void Withdrawl(int amount)
        {
            if (_balance - amount < _minimumBalance)
            {
                throw new Exception("Withdrawl Unsuccessful");
            }
            _balance -= amount;
        }
    }
}
