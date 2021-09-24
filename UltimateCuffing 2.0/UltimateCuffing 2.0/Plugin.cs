using System;
using Player = Exiled.Events.Handlers.Player;
using Exiled.API.Features;

namespace UltimateCuffing_2._0
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "G-Man";
        public override string Name { get; } = "UltimateCuffing";
        public override string Prefix { get; } = "UltimateCuffing";
        public override Version Version { get; } = new Version(2, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(3, 0, 0);
        public EventHandlers EventHandler;

        public override void OnEnabled()
        {
            EventHandler = new EventHandlers(this);
            Player.Handcuffing += EventHandler.OnCuffed;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Player.Handcuffing -= EventHandler.OnCuffed;
            EventHandler = null; 
            base.OnDisabled();
        }
    }
}
