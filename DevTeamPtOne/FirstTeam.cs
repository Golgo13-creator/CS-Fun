using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamPtOne
{
    class FirstTeam : Team
    {
        public FirstTeam(string teamName, int teamId, string teamMember, bool hasPluralSightAcct)
            :base(teamName, teamId, teamMember)
        {
                
        }
    }
    class TeamTwo : Team
    {
        public TeamTwo(string teamName, int teamId, string teamMember, bool hasPluralSightAcct)
            : base(teamName, teamId, teamMember)
        {

        }
    }
}
