using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Van : BaseDomainModel
    {
        public string VanType { get; set; }
        public string VanBrand { get; set; }
        public string VanPlate { get; set; }
        public string VanRates { get; set; }
    }
}
