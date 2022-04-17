using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchOffside : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int OffsidesForAt10 { get; set; }
        public int OffsidesForAt20 { get; set; }
        public int OffsidesForAt30 { get; set; }
        public int OffsidesForAt40 { get; set; }
        public int OffsidesForAt50 { get; set; }
        public int OffsidesForAt60 { get; set; }
        public int OffsidesForAt70 { get; set; }
        public int OffsidesForAt80 { get; set; }
        public int OffsidesFor { get; set; }
    }
}
