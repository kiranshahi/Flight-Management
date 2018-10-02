namespace FlightManagement.Domain
{
    public class Cargo
    {
        public int? Id { get; set; }
        public int PlaneId { get; set; }
        public string PlaneName { get; set; }
        public string CargoItem { get; set; }
    }
}
