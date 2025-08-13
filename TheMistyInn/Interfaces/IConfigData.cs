using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMistyInn.Models;
using TheMistyInn.Services.Configuration;

namespace TheMistyInn.Interfaces
{
    public interface IConfigData
    {
        Task<Result<string, SystemError<ConfigurationDataServiceProvider>>> GetBotTokenAsync();
    }
}
