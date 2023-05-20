using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMSM.Classes
{
    public class Salaries
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string MonthName { get; set; }
        public string IsPaid { get; set; }
        public string Date { get; set; }    
        public int Ammount { get; set; }
        public string Designation { get; set; }
    }
}
