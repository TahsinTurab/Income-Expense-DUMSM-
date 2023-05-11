using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM.Classes
{
    public class GeneralIncome
    {
        string SlipNumber { get; set; }
        public string Field { get; set; }
        public bool IsDonation { get; set; }
        public string DonationId { get; set; }
        public DateTime RegisterDate { get; set; }
        public int Ammount { get; set; }
    }
}
