namespace InterviewTestSRP
{
    public interface IVehicle
    {
        double Length { get; set; }
        string Make { get; set; }
        string ManufacturingDate { get; set; }
        string ManufacturingTime { get; set; }
        string Model { get; set; }
        string Reg { get; set; }
        double Width { get; set; }

        string VehicleType { get; }

        string ToString();
    }
}