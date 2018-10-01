using System;

namespace FlightManagement.Domain
{
    public class PlaneBook
    {
        public int Id { get; set; }
        public string BookedBy { get; set; }
        public int PlaneId { get; set; }
        public int CustomerId { get; set; }
        public int CargoId { get; set; }
        public DateTime Departure { get; set; }
        public DateTime Arrival { get; set; }
        public Plane PlaneList { get; set; }
        public Customer CustomerList { get; set; }
        public Cargo CargoList { get; set; }
    }
}
