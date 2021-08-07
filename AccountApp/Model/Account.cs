using System;

namespace AccountApp.Model
{
    public class Account
    {
        private int _accNO;
        private String _accName;
        private double _balance, _minimumBalance=500;
        private static int _headCount = 0;

        public int AccNo
        {
            get
            {
                return _accNO;
            }
        }
        public double Balance
        {
            get
            {
                return _balance;
            }
        }
        public String AccName
        {
            get
            {
                return _accName;
            }
            set
            {
                _accName = value;
            }
        }
        public static int HeadCount
        {
            get
            {
                return _headCount;
            }
        }

        public Account(int accNo, String accName, double accBalance)
        {
            _accNO = accNo;
            _accName = accName;
            _balance = accBalance;
            _headCount++;
        }
        public Account(int accNo, String accName):this(accNo,accName,500)
        {

        }

        public void Withdrawl(int amount)
        {
            if ((_balance - amount) < _minimumBalance)
            {
                throw new Exception("Withdrawl unsuccessful.");
            }
            _balance -= amount;
        }
        public void Deposit(int amount)
        {
            _balance += amount;
        }
    }
}
