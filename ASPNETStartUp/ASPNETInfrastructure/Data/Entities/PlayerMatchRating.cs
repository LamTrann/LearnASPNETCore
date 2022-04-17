using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class PlayerMatchRating : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public virtual InstatPlayer InstatPlayer { get; set; }
        public int InstatSeasonId { get; set; }
        public double PlayerRating { get; set; }

    }
}
