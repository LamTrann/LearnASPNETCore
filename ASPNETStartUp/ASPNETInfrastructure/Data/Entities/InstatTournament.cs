using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class InstatTournament : BaseEntity<Guid>
    {
        public int InstatId { get; set; }
        public string InstatName { get; set; }
    }
}
