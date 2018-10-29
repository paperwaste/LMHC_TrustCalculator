using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMHC_TrustCalculator.Model
{
    public class ServiceFee
    {

        public int ServiceFeeId { get; set;}
        public double Rate { get; set; }
        public string Type { get; set; }

        public int PracticeId { get; set; }
        public Practice Practice { get; set; }
    }
}
