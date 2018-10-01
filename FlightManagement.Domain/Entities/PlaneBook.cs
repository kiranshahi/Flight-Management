using System;
using System.Collections.Generic;

namespace FlightManagement.Domain
{
    public class PlaneBook
    {
        public int Id { get; set; }       
        public DateTime BookFor { get; set; }
        public Plane PlaneList { get; set; }
        public Customer CustomerList { get; set; }
    }
}
