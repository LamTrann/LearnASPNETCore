using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchShotsOnTarget : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int ShotsOnForAt10 { get; set; }
        public int ShotsOnForAt15 { get; set; }
        public int ShotsOnForAt20 { get; set; }
        public int ShotsOnForAt25 { get; set; }
        public int ShotsOnForAt30 { get; set; }
        public int ShotsOnForAt35 { get; set; }
        public int ShotsOnForAt40 { get; set; }
        public int ShotsOnForAt45 { get; set; }
        public int ShotsOnForAt50 { get; set; }
        public int ShotsOnForAt55 { get; set; }
        public int ShotsOnForAt60 { get; set; }
        public int ShotsOnForAt65 { get; set; }
        public int ShotsOnForAt70 { get; set; }
        public int ShotsOnForAt75 { get; set; }
        public int ShotsOnForAt80 { get; set; }
        public int ShotsOnForAt85 { get; set; }

    }
}
