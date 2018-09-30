namespace FlightManagement.Domain
{
    public class Plane
    {
        public int Id { get; set; }
        public string PlaneName { get; set; }
        public string PlaneType { get; set; }
        public int Capacity { get; set; }
        public int PassengerNumber { get; set; }
    }
}
