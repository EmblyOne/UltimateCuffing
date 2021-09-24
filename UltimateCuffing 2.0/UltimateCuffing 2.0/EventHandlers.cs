using System;
using Exiled.Events.EventArgs; 

namespace UltimateCuffing_2._0
{
    public class EventHandlers
    {
        public Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void OnCuffed(HandcuffingEventArgs ev)
        {
            if (plugin.Config.cuffedteams == null)
                return;
            if (ev.Cuffer.Team == ev.Target.Team && plugin.Config.cuffedteams.Contains(ev.Target.Team))
                ev.IsAllowed = true; 
        }
    }
}
