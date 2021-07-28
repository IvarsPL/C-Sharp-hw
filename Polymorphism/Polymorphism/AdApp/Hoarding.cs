namespace AdApp
{
    public class Hoarding : Advert
    {
        private int _rate;
        //per day
        private int _numDays;

        public Hoarding(int fee, int numDays, int rate) : base(fee)
        {

        }

        public new int Cost()
        {
            return base.Cost();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}