using Exiled.API.Features;
using Exiled.API.Interfaces;
using System;
using System.ComponentModel;

namespace UltimateCuffing
{
    public class Config : IConfig
    {
        [Description("Whether or not this plugin is enabled")]
        public bool IsEnabled { get; set; } = true;

        [Description("Can class-d cuff class-d?")]
        public bool classd { get; set; } = true;

        [Description("Can Scientists cuff scientists?")]
        public bool rsc { get; set; } = true;

        [Description("Can Mobile Task Force cuff Mobile Task Force?")]
        public bool mtf { get; set; } = true;

        [Description("Can Tutorial cuff Tutorial?")]
        public bool tutorial { get; set; } = true;

        [Description("Can Chaos Insurgency cuff Chaos Insurgency?")]
        public bool chaos { get; set; } = true; 
    }
}
