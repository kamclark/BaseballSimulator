using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballLibrary
{
    public class TeamModel
    {
        public List<PlayerModel> Roster { get; set; }
        public string TeamName { get; set; }
        public string Logo { get; set; }
        public string Location { get; set; }
    }
}
