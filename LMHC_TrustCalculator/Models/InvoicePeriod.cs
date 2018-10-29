using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMHC_TrustCalculator.Model
{
    public class InvoicePeriod
    {
        public int InvoicePeriodId { get; set; }
        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public virtual IEnumerable<TaxAdjustmentInvoice> TaxAdjustmentInvoices { get; set; }

      
    }
}
