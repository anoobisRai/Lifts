using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lifts.Shared.Domain
{
    public class Coach : BaseDomainModel
    {
        public string CoachType { get; set; }
        public string CoachBrand { get; set; }
        public string CoachPlate { get; set; }
        public string CoachRates { get; set; }
    }
}
