using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchYellow : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int YellowsForAt10 { get; set; }
        public int YellowsForAt20 { get; set; }
        public int YellowsForAt30 { get; set; }
        public int YellowsForAt40 { get; set; }
        public int YellowsForAt50 { get; set; }
        public int YellowsForAt60 { get; set; }
        public int YellowsForAt70 { get; set; }
        public int YellowsForAt80 { get; set; }
        public int YellowsFor { get; set; }
    }
}
