using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMistyInn.Enums;

namespace TheMistyInn.Models
{
    public class Player
    {
        public int Id { get; set; }
        public required string UserName { get; set; }
        public required string GuildId { get; set; }
        public required string UserId { get; set; }
        public Charecter? Charecter { get; set; }   
    }
}
