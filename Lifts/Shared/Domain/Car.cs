using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Car : BaseDomainModel
    {
        public string CarType { get; set; }
        public string CarBrand { get; set; }
        public string CarPlate { get; set; }
        public string CarRates { get; set; }
    }
}
