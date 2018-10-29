using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMHC_TrustCalculator.Model
{
    public class TaxAdjustmentInvoice
    {

        public int TaxAdjustmentInvoiceId { get; set; }

        public Doctor Doctor { get; set; }

        public ServiceFee ServiceFee { get; set; }

        public Practice Practice { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public InvoicePeriod InvoicePeriod {get; set;}

        public double AmountPaidGstExcluded{ get; set; }

        public double GstPaid { get; set; }

        public string Html { get; set; }

        public double GstFreeFeesRecieved { get
            {
                return AmountPaidGstExcluded - (10 * GstPaid);
            } }

        public double GstNotFreeFeesRecieved { get
            {
                return 10 * GstPaid + GstPaid;
            } }

        public double ServiceFeeGstFree
        {
            get
            {
                return GstFreeFeesRecieved * ServiceFee.Rate;
            }
        }

        public double ServiceFeeNotGstFree { get
            {
                return (10 * GstPaid) * ServiceFee.Rate;
            }
        }

    }
}
