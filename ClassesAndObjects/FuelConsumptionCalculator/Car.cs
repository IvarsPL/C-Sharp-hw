namespace FuelConsumptionCalculator
{
    public class Car
    {
        public int StartOdo;
        public int StartKilometers;
        public double Liters;
        public Car(int startOdo)
        {
            this.StartOdo = startOdo;
        }

        public double CalculateConsumption()
        {
            return (StartOdo - StartKilometers) / Liters;
        }

        private double ConsumptionPer100Km()
        {
            return CalculateConsumption() / 100;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
        }
    }
}
