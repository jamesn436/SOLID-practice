namespace InterviewTestSRP
{
    public interface IMotorBike : IVehicle
    {
        bool Modified { get; set; }
        bool SingleSeat { get; set; }

        string ToString();
    }
}