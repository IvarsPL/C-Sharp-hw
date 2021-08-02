namespace Account
{
    public class Account
    {
        private string _name;
        private double _balance;

        public Account(string v1, double v2)
        {
            _name = v1;
            _balance = v2;
        }

        public double Withdrawal(double i)
        {
            _balance -= i;
            return i;
        }

        public void Deposit(double i)
        {
           _balance+=i;
        }

        public double Balance()
        {
            return _balance;
        }

        public override string ToString()
        {
            return $"{_name}: {_balance}";
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }
}
