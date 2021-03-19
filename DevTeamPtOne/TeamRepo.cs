using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamPtOne
{
    public class TeamRepo
    {
        protected readonly List<Team> _teamDir = new List<Team>();
        protected readonly List<Users> _userDir = new List<Users>();
        //create users
        public bool AddContentToDir(Users user)
        {
            int StartingCount = _userDir.Count();
            _userDir.Add(user);
            bool wasAdded = (_userDir.Count > StartingCount) ? true : false;
            return wasAdded;
        }
        //create new teams
        public bool AddTeams(Team teams)
        {
            int StartingCount = _teamDir.Count();
            _teamDir.Add(teams);
            bool wasAdded = (_teamDir.Count > StartingCount) ? true : false;
            return wasAdded;
        }
        //gets team by team ID
        public Team GetTeamByTeamID(int teamId)
        {
            foreach(Team teams in _teamDir)
            {
                if(teams.TeamID == teamId)
                {
                    return teams;
                }
            }
            return null;
        }
        //delete by team ID
        public bool DeleteTeamByTeamID(Team teamId)
        {
            bool deleteTeam = _teamDir.Remove(teamId);
            return deleteTeam;
        }
    }
}
