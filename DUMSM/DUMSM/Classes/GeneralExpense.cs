using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM.Classes
{
    public class GeneralExpense
    {
        public string VoucherNumber { get; set; }
        public DateTime ExpenseDate { get; set; }
        public string Field { get; set; }
        public int Ammount { get; set; }
    }
}
