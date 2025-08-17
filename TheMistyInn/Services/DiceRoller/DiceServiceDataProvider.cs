using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMistyInn.Interfaces;
using TheMistyInn.Models;

namespace TheMistyInn.Services.DiceRoller
{
    public class DiceServiceDataProvider : IDiceService
    {
        public async Task<Result<Dice, SystemError<DiceServiceDataProvider>>> Roll(int sides, int dice = 6, double modifier = 0.1)
        {
            throw new NotImplementedException();
        }
    }
}
