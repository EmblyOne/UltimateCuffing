using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;

namespace UltimateCuffing
{
     
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "Space";
        public override string Name { get; } = "UltimateCuffing";
        public override string Prefix { get; } = "UltimateCuffing";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(2, 10, 0);

        public EventHandlers EventHandler; 

        public override void OnEnabled()
        {  
            EventHandler = new EventHandlers(this);
            Player.Handcuffing += EventHandler.OnCuff;

            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Player.Handcuffing -= EventHandler.OnCuff;

            EventHandler = null; 
        }
    }
}
