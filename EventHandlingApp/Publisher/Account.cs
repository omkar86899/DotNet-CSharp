using System;

namespace EventHandlingApp.Publisher
{
    public delegate void AccountHandler(Account acc);
    public class Account
    {
        private int _accNo;
        private String _accName;
        private double _balance;
        private double _minimumBalance = 1000;

        public int AccNo
        {
            get { return _accNo; }
        }
        public String AccName
        {
            get { return _accName; }
            set { _accName = value; }
        }
        public double Balance
        {
            get { return _balance; }
        }

        public Account(int accNo, String accName, double balance)
        {
            _accName = accName;
            _accNo = accNo;
            _balance = balance;
        }

        public event AccountHandler BalanceChanged;

        public void Deposit(double amount)
        {
            _balance += amount;
            if(BalanceChanged != null)
            {
                BalanceChanged(this);
            }
        }

        public void Withdrawl(double amount)
        {
            if (_balance - amount < _minimumBalance)
            {
                throw new Exception("Withdrawl Unsuccessful");
            }
            _balance -= amount;
            if (BalanceChanged != null)
            {
                BalanceChanged(this);
            }
        }
    }
}
