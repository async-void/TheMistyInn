using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TheMistyInn.Interfaces;
using TheMistyInn.Models;

namespace TheMistyInn.Services.Configuration
{
    public class ConfigurationDataServiceProvider : IConfigData
    {
        public async Task<Result<string, SystemError<ConfigurationDataServiceProvider>>> GetBotTokenAsync()
        {
            var path = Path.Combine(AppContext.BaseDirectory, "Config", "config.json");
            var file = await File.ReadAllTextAsync(path);
            var json = JsonSerializer.Deserialize<ConfigJson>(file);

            if (json is null || string.IsNullOrEmpty(json.Token))
            {
                return Result<string, SystemError<ConfigurationDataServiceProvider>>.Err(
                    new SystemError<ConfigurationDataServiceProvider>
                    {
                        ErrorCode = Guid.NewGuid(),
                        ErrorMessage = "Bot token is not set in the configuration file.",
                        ErrorType = Enums.ErrorType.WARNING,
                        CreatedBy = this,
                    });
            }
            return Result<string, SystemError<ConfigurationDataServiceProvider>>.Ok(json.Token);
        }
    }
}
