using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM.Classes
{
    public class GeneralIncome
    {
        public Guid Id { get; set; }
        public string SlipNumber { get; set; }
        public string Field { get; set; }
        public string IsDonation { get; set; }
        public string DonationId { get; set; }
        public string RegisterDate { get; set; }
        public int Ammount { get; set; }
        public int MonthName { get; set; }
        public int Year { get; set; }
    }
}
