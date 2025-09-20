using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace At_day__at_night
{
    internal class Oceanarium
    {
        public string? Name { get; set; }
        public string? Location { get; set; }
        public int? SumOfFish { get; set; }
        public int? TicketPrice { get; set; }

        public Oceanarium(string name, string location, int Sof, int? ticketPrice)
        {
            Name = name;
            Location = location;
            SumOfFish = Sof;
            TicketPrice = ticketPrice;
        }
        public override string ToString()
        {
            return $"{Name} {Location} {SumOfFish} {TicketPrice}";
        }
    }
     
    class Fish() { }
    class Medusa() { }

    //class  () { }
}
