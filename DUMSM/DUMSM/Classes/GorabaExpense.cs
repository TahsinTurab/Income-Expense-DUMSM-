using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM.Classes
{
    public class GorabaExpense
    {
        public Guid Id { get; set; }
        public string VoucherNumber { get; set; }
        public string ExpenseDate { get; set; }
        public string Field { get; set; }
        public int Ammount { get; set; }
    }
}
