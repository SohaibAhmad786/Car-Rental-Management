using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement
{
    public class FinanceModel
    {
        public String regNum { get; set; }
        public List<float> price { get; set; }
        public List<float> fine { get; set; }
        public List<float> maintenanceCost { get; set; }
    }
}
