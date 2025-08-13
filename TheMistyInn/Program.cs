using DSharpPlus;
using DSharpPlus.Commands;
using DSharpPlus.Commands.Processors.SlashCommands;
using DSharpPlus.Commands.Processors.TextCommands;
using DSharpPlus.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Sinks.SystemConsole.Themes;
using System.Reflection;
using TheMistyInn.Interfaces;
using TheMistyInn.Services;
using TheMistyInn.Services.Configuration;

namespace TheMistyInn
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var configService = new ConfigurationDataServiceProvider();
            var token = await configService.GetBotTokenAsync();
            if (!token.IsOk)
            {
                Console.WriteLine($"Error fetching bot token");
                return;
            }

            var intents = TextCommandProcessor.RequiredIntents | SlashCommandProcessor.RequiredIntents | DiscordIntents.All;

            var logger = Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .MinimumLevel.Override("System.Net.Http", Serilog.Events.LogEventLevel.Error)
                .WriteTo.Console(theme: AnsiConsoleTheme.Code, outputTemplate: "[{Timestamp:yyyy-MM-dd hh:mm:ss.fff tt zzz} {SourceContext} {Level:u3}] {Message:lj}{NewLine}")
                .WriteTo.File(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "TextFiles", "Logs", "bot_logs.txt"), rollingInterval: RollingInterval.Day,
                 outputTemplate: "[{Timestamp:yyyy-MM-dd hh:mm:ss.fff tt zzz} {SourceContext} {Level:u3}] {Message:lj}{NewLine}")
                .CreateLogger();

            #region DEFAULT HOST    
            await Host.CreateDefaultBuilder()
                .UseSerilog()
                .UseConsoleLifetime()
                .ConfigureServices((context, services) =>
                {
                    services.AddHostedService<BotService>()
                        .AddDiscordClient(token.Value, intents)
                        .AddCommandsExtension((context, config) =>
                        {
                            config.AddCommands(Assembly.GetExecutingAssembly());
                        });
                    services.AddLogging(logging => logging.ClearProviders().AddSerilog(logger));
                    services.AddScoped<IConfigData, ConfigurationDataServiceProvider>();
                })
                .RunConsoleAsync();
            #endregion
        }
    }
}
