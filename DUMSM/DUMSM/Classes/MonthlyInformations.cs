using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM.Classes
{
    public class MonthlyInformations
    {
        public string EmployeeId { get; set; }
        public int TotalPresrnt { get; set; }
        public int TotalAbsent { get; set; }
        public int TotalLeave { get; set; }
        public int BaseSalary { get; set; }
        public int ExtraHonorium { get; set; }
        public int Due { get; set; }
        public int TotalAmmount { get; set; }
        public int ProvidentFund { get; set; }
        public int Loan { get; set; }
        public int Advance { get; set; }
        public int NetPayableAmmount { get; set; }
        public string MonthName { get; set; }
        public DateTime PaymentDate { get; set; }
        public bool IsPaid { get; set; }
    }
}
