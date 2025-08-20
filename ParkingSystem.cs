namespace Assignment_7._4
{
    public class ParkingSystem
    {
        private int SmallSpaces { get; }
        private int MediumSpaces { get; }
        private int LargeSpaces { get; }

        private int SmallCount { get; set; }
        private int MediumCount { get; set; }
        private int LargeCount { get; set; }

        public ParkingSystem(int large, int medium, int small)
        {
            SmallSpaces = small;
            MediumSpaces = medium;
            LargeSpaces = large;

            SmallCount = small;
            MediumCount = medium;
            LargeCount = large;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (LargeCount > 0)
                    {
                        LargeCount--;
                        return true;
                    }
                    else return false;

                case 2:
                    if (MediumCount > 0)
                    {
                        MediumCount--;
                        return true;
                    }
                    else return false;
                case 3:
                    if (SmallCount > 0)
                    {
                        SmallCount--;
                        return true;
                    }
                    else return false;
                default:
                    Console.Write("Invalid car type; ");
                    return false;
            }
        }
    }
}
