using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevTeamPtOne
{
    
    public class Users 
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public string LastName { get; set; }
        public bool HasPluralSightAcct { get; set; }
        public Users(int id, string teamName, string lastName, bool hasPluralSightAcct)
        {
            ID = id;
            TeamName = teamName;
            LastName = lastName;
            HasPluralSightAcct = hasPluralSightAcct;
        }
    }
}
