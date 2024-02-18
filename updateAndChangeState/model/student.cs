using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace updateAndChangeState.model
{
    internal class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public virtual course? course { get; set; }
        public List<int> myList { get; set; } = new List<int>();
    }
}
