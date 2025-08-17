using DSharpPlus;
using DSharpPlus.Entities;
using DSharpPlus.EventArgs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheMistyInn.EventHandlers
{
    public class InteractionHandler : IEventHandler<InteractionCreatedEventArgs>
    {
        public Task HandleEventAsync(DiscordClient sender, InteractionCreatedEventArgs eventArgs)
        {
            switch (eventArgs.Interaction.Type)
            {
                case DiscordInteractionType.ApplicationCommand:
                    return Task.CompletedTask;
                case DiscordInteractionType.Component:
                    return Task.CompletedTask;
                case DiscordInteractionType.ModalSubmit:
                    return Task.CompletedTask;
                default:
                    return Task.CompletedTask;
            }
        }
    }
}
