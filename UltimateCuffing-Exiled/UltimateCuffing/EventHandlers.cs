using Exiled.API.Features;
using Exiled.Events.EventArgs;

namespace UltimateCuffing
{
    public class EventHandlers
    {
        public Plugin plugin;
        public EventHandlers(Plugin plugin) => this.plugin = plugin;
        public void OnCuff(HandcuffingEventArgs ev)
        {
            if (ev.Cuffer.Team == Team.CDP && ev.Target.Team == Team.CDP && plugin.Config.classd)
            {
                
                
                    ev.IsAllowed = true; 
                
            } 
            if (ev.Cuffer.Team == Team.CHI && ev.Target.Team == Team.CHI && plugin.Config.chaos)
            {

                
                    ev.IsAllowed = true;
                
            } 
            if (ev.Cuffer.Team == Team.MTF && ev.Target.Team == Team.MTF && plugin.Config.mtf)
            {
                
                
                    ev.IsAllowed = true;
                
            } 
            if (ev.Cuffer.Team == Team.RSC && ev.Target.Team == Team.RSC && plugin.Config.rsc)
            {
                
                
                    ev.IsAllowed = true;
                
            } 
            if (ev.Cuffer.Team == Team.TUT && ev.Target.Team == Team.TUT && plugin.Config.tutorial)
            {
                
                
                    ev.IsAllowed = true; 
                
            }
        } 
    }
}
