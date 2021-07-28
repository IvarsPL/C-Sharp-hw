namespace Firm
{
    public class Commission : Hourly
    {
        private double _totalSales;
        private double _commissionPercent;
        public double TotalSales { get; set; }
        public double CommissionSales { get; set; }
        public Commission(string eName, string eAddress, string ePhone, string socSecNumber, double rate, double commissionPercent) : base(eName, eAddress, ePhone, socSecNumber, rate)
        {
            _commissionPercent = commissionPercent;
        }

        public void AddSales(double totalSales)
        {
            _totalSales += totalSales;
        }

        public override double Pay()
        {
            var payment = base.Pay() + (_commissionPercent * _totalSales);
            _commissionPercent = 0;
            return payment;

        }

        public override string ToString()
        {
            var result = base.ToString();
            result += "\nTotal Sales: " + _totalSales;
            result += "\nTotal Commission: " + _totalSales * _commissionPercent;

            return result;
        }
    }
}
