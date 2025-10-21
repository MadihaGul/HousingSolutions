using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HousingSolutions.Domain.Entities
{
    public class Booking
    {
        public int Id { get; set; }
        public string ResidentName { get; set; } = "";
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }

}
