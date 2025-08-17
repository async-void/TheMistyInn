using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMistyInn.Models;
using TheMistyInn.Services.DiceRoller;

namespace TheMistyInn.Interfaces
{
    public interface IDiceService
    {
        Task<Result<Dice, SystemError<DiceServiceDataProvider>>> Roll(int sides, int dice = 6, double modifier = 0.1);
    }
}
