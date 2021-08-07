using System;

namespace AccountInterfaceApp.Model
{
    public abstract class Account
    {
        private int _accNo;
        private String _accName;
        protected double _balance;
        protected static int _headCount;

        public Account(int accNo, String accName, double balance)
        {
            _accNo = accNo;
            _accName = accName;
            _balance = balance;
            _headCount++;
        }
        public void Deposit(int amount)
        {
            _balance += amount;
        }
        public abstract void Withdrawl(int amount);

        public String AccountName
        {
            get { return _accName; }
            set { _accName = value; }
        }
        public int AccountNo
        {
            get { return _accNo; }
        }
        public double Balance
        {
            get { return _balance; }
        }
        public static int HeadCount
        {
            get { return _headCount; }
        }
    }
}
