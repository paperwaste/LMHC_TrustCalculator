using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMHC_TrustCalculator.Model
{
    public class Practice
    {
        public int PracticeId { get; set; }
        public string Name { get; set; }

        public long ABN { get; set; }

        public string Address { get; set; }

        public string AddressCity { get; set; }

        public string AddressState { get; set; }

        public string AddressCountry { get; set; }

        public string AddressPostCode { get; set; }


        public virtual List<ServiceFee> ServiceFees { get; set; }


        public virtual List<Adjustment> Adjustments { get; set; }
    }
}
