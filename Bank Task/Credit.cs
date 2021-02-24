using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task
{
    class Credit : Instance
    {
        public Client client { get; set; }
        public double amount { get; set; }
        public double percent { get; set; }
        public int months { get; set; }
        public double Payment { get; set; }
        public void CalculatePercent (){
            }

    }
}
