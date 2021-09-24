using System;
using System.Collections.Generic;
using Exiled.API.Interfaces; 

namespace UltimateCuffing_2._0
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public List<Team> cuffedteams { get; } = new List<Team> { Team.CDP, Team.TUT, Team.SCP, Team.MTF, Team.CHI };
    }
}
