using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class InstatPlayer : BaseEntity<Guid>
    {
        public int InstatPlayerId { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public string PlayerName { get; set; }
      
    }
}
