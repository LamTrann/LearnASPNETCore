using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchRed : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int RedsForAt10 { get; set; }
        public int RedsForAt20 { get; set; }
        public int RedsForAt30 { get; set; }
        public int RedsForAt40 { get; set; }
        public int RedsForAt50 { get; set; }
        public int RedsForAt60 { get; set; }
        public int RedsForAt70 { get; set; }
        public int RedsForAt80 { get; set; }
        public int RedsFor { get; set; }
    }
}
