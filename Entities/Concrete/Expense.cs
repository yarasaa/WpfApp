using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Expense:IEntity
    {
        public int ID { get; set; }
        public double Salary { get; set; }
        public double Car { get; set; }
        public double Clothing { get; set; }
        public double Food { get; set; }
        public double Leisure { get; set; }
        public double Living { get; set; }
    }
}
