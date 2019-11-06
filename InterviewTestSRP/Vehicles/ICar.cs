namespace InterviewTestSRP
{
    public interface ICar : IVehicle
    {
        int NumAirBags { get; set; }
        int NumDoors { get; set; }
        int NumSeats { get; set; }

        string ToString();
    }
}