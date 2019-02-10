namespace MySolution
{
    public class Car
    {
        private double _oilRate = 0.1;

        public Car(double oilRate)
        {
            _oilRate = oilRate;
        }

        public double ReturnDistance(int oil)
        {
            return oil / _oilRate;
        }

        public double ReturnColor(int oil)
        {
            return oil / _oilRate;
        }
    }
}
