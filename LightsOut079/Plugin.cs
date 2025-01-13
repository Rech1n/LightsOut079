using System;
using Exiled.API.Features;
using Exiled.API.Enums;

namespace LightsOut079
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "LightsOut079";
        public override string Author => "Recha_";
        public override Version RequiredExiledVersion => new Version(9, 3, 0); 
        public override PluginPriority Priority => PluginPriority.Medium;

        public static Plugin Instance;

        public EventHandlers EventHandlers;

        public override void OnEnabled()
        {
            Instance = this;
            EventHandlers = new EventHandlers();
            Exiled.Events.Handlers.Player.Shooting += EventHandlers.OnShooting;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.Shooting -= EventHandlers.OnShooting;
            EventHandlers = null;
            Instance = null;
            base.OnDisabled();
        }
    }
}
