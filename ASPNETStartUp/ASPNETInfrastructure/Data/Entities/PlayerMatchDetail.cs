using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class PlayerMatchDetail : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public virtual InstatPlayer InstatPlayer { get; set; }
        public bool Start { get; set; }
        public bool Sub { get; set; }
        public int GoalsScored { get; set; }
        public int RedCards { get; set; }
        public int YellowCards { get; set; }
        public double MinutesPlayed { get; set; }
        public int InstatPositionId { get; set; }
        public int? ShirtNumber { get; set; }
    }
}
