using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMistyInn.Enums;

namespace TheMistyInn.Models
{
    public class Charecter
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? AvatarUrl { get; set; }
        public int HitPoints { get; set; }
        public int Strength { get; set; }
        public int Defense { get; set; }
        public int Intelligence { get; set; }
        public CharecterClass Class { get; set; }
        public CharecterRace Race { get; set; }
    }
}
