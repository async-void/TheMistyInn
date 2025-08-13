using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheMistyInn.Interfaces;
using TheMistyInn.Models;

namespace TheMistyInn.Services.Configuration
{
    public class ConfigurationDataServiceProvider : IConfigData
    {
        public async Task<Result<string, SystemError<ConfigurationDataServiceProvider>>> GetBotTokenAsync()
        {
            
        }
    }
}
