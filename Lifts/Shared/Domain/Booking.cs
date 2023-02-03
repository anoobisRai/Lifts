using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public DateTime BookingDate { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime StartTime { get; set; }

        public DateTime EndTime { get; set; }
        public int CustomersId { get; set; }
        public virtual Customer Customer { get; set; }
        public int VehicleID { get; set; }
        public virtual Vehicles Vehicles { get; set; }
        public int StaffId { get; set; }
        public virtual Staff Staff { get; set; }
        public virtual List<Payment> Payment { get; set; }
    }
}
