using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseReportV2.ExpenseReport
{
    public enum Status
    {
        APPROVED, REWORK, REJECTED, PROCESSING, COMPLETED
    }
    public class Claims
    {

        public DateTime PreparedDate  { get; set; }
        public DateTime ReceiptDate  { get; set; }
        public DateTime UpdatedDate { get; set; }


        public int MinistryId { get; set; }
        public string MinistryName { get; set; } // do we need this?

        public int TeamId { get; set; }
        public string TeamName { get; set; } // again do we need this?
        public long TotalAmount { get; set; }
        public long NetAmount { get; set; }
        public long Gst { get; set; }
        public long Pst { get; set; }
        public string Payee { get; set; }
        public string ProjectName { get; set; }
        public bool BudgetConfirm { get; set; }

        public DateTime RecipientPickUpDate { get; set; }
        public string RecipientFullName { get; set; }
        public string RecipientSignature { get; set; }
        public string ChequeNumber { get; set; }



        // TODO: we will create associative entity for 
        //public Status Status { get; set; }
        //public int ApprovedTeamLeaderId { get; set; }
        //public int ApprovedMinistryLeaderId { get; set; }
        //public int ApprovedStaffId { get; set; }
        //public int ApprovedFinancialId { get; set; }



    }
}
