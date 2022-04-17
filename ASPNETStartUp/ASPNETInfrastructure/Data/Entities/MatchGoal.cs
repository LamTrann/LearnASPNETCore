using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchGoal : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int GoalsForAt10 { get; set; }
        public int GoalsForAt15 { get; set; }
        public int GoalsForAt20 { get; set; }
        public int GoalsForAt25 { get; set; }
        public int GoalsForAt30 { get; set; }
        public int GoalsForAt35 { get; set; }
        public int GoalsForAt40 { get; set; }
        public int GoalsForAt45 { get; set; }
        public int GoalsForAt50 { get; set; }
        public int GoalsForAt55 { get; set; }
        public int GoalsForAt60 { get; set; }
        public int GoalsForAt65 { get; set; }
        public int GoalsForAt70 { get; set; }
        public int GoalsForAt75 { get; set; }
        public int GoalsForAt80 { get; set; }
       
    }
}
