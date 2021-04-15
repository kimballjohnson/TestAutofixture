using System.Collections.Generic;

namespace ImprovingCodeDesign
{
    public class Booking
    {
        public string BookingReference { get; set; }
        public string CustomerName { get; set; }
        public List<FlightDetails> Legs { get; set; } = new List<FlightDetails>();
    }
}
