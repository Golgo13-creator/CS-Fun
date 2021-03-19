using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamPtOne
{
    public class Team
    {
        public string TeamName { get; set; }
        public int TeamID { get; set; }
        public string TeamMember { get; set; }


        public Team()
        {

        }
        public Team(string teamName, int teamId, string teamMember)
        {
            TeamName = teamName;
            TeamID = teamId;
            TeamMember = teamMember;
        }
    }
}
