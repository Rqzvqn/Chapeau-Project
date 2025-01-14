using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChapeauModel
{
    public class Table
    {
        public int TableId { get; set; }
        public int Capacity { get; set; } //????
        public int TableNumber { get; set; }
        public TableStatus Status { get; set; }
    }
}
