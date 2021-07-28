namespace AdApp
{
    class Poster : Advert
    {
        private double _dimensionX;
        private double _dimensionY;
        private int _numOfCopies;
        private double _costPerCopy;

        public Poster(int fee, double dimensionX, double dimensionY, int numOfCopies, double costPerCopy) : base(fee)
        {
            _dimensionX = dimensionX;
            _dimensionY = dimensionY;
            _numOfCopies = numOfCopies;
            _costPerCopy = costPerCopy;
        }

        public new int Cost()
        {
            var fee = base.Cost();
            return fee;
        }
    }
}
