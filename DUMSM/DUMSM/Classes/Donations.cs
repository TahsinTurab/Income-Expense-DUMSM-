﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM.Classes
{
    public class Donations
    {
        public string SlipNumber { get; set; }
        public int DonationAmmount { get; set; }
        public string DonorId { get; set; }
        public string DonationType { get; set; }  
        public string DonationField { get; set; }
        public DateTime DonationDate { get; set; }
    }
}
