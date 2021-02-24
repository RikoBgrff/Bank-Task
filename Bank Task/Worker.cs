using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Task
{
    class Worker:Human
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<Operation> operations { get; }
        public void AddOperation(Operation operation)
        {
            operations.Add(operation);
        }

    }
}
