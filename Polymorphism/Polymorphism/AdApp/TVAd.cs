namespace AdApp
{
    public class TvAd: Advert
    {
        public TvAd(int fee) : base(fee)
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