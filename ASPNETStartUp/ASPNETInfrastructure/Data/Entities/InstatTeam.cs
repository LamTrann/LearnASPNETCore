 using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class InstatTeam : BaseEntity<Guid>
    {
        public int InstatId { get; set; }
        public string InstatName { get; set; }
        virtual public InstatTournament CurrentInstatTournament { get; set; }
    }
}
