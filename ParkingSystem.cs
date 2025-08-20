namespace Assignment_7._4
{
    public class ParkingSystem
    {
        public int SmallSpaces { get; set; }
        public int MediumSpaces { get; set; }
        public int LargeSpaces { get; set; }

        public ParkingSystem(int large, int medium, int small)
        {
            SmallSpaces = small;
            MediumSpaces = medium;
            LargeSpaces = large;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (SmallSpaces > 0)
                    {
                        SmallSpaces--;
                        return true;
                    }
                    else return false;
                case 2:
                    if (MediumSpaces > 0)
                    {
                        MediumSpaces--;
                        return true;
                    }
                    else return false;
                case 3:
                    if (LargeSpaces > 0)
                    {
                        LargeSpaces--;
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
