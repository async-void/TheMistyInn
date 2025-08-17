using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMistyInn.Models
{
    public class Dice
    {
        public int Id { get; set; }
        public int Sides { get; set; }
        public int DieCount { get; set; }
        public double Modifier { get; set; }
        public int Result { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
