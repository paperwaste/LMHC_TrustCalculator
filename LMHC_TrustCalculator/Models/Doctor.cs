using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMHC_TrustCalculator.Model
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public long ABN { get; set; }

        public string ProviderNo { get; set; }

        public string Address { get; set; }

        public string AddressCity { get; set; }

        public string AddressState { get; set; }

        public string AddressCountry { get; set; }

        public string AddressPostCode { get; set; }

        public virtual ServiceFee ServiceFee { get; set; }
        
        public int ServiceFeeId { get; set; }



        
    }
}
