
using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchFoul : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int FoulsForAt10 { get; set; }
        public int FoulsForAt20 { get; set; }
        public int FoulsForAt30 { get; set; }
        public int FoulsForAt40 { get; set; }
        public int FoulsForAt50 { get; set; }
        public int FoulsForAt60 { get; set; }
        public int FoulsForAt70 { get; set; }
        public int FoulsForAt80 { get; set; }
        public int FoulsFor { get; set; }
    }
}
