using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Vehicles : BaseDomainModel
    {
        public int CoachID { get; set; }
        public virtual Coach Coach { get; set; }
        public int CarID { get; set; }
        public virtual Car Car { get; set; }
        public int VanID { get; set; }
        public virtual Van Van { get; set; }
        public virtual List<Booking> Booking { get; set; }
    }
}
