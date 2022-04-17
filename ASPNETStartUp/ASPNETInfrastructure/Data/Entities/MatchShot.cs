using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchShot : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int ShotsForAt10 { get; set; }
        public int ShotsForAt15 { get; set; }
        public int ShotsForAt20 { get; set; }
        public int ShotsForAt25 { get; set; }
        public int ShotsForAt30 { get; set; }
        public int ShotsForAt35 { get; set; }
        public int ShotsForAt40 { get; set; }
        public int ShotsForAt45 { get; set; }
        public int ShotsForAt50 { get; set; }
        public int ShotsForAt55 { get; set; }
        public int ShotsForAt60 { get; set; }
        public int ShotsForAt65 { get; set; }
        public int ShotsForAt70 { get; set; }
        public int ShotsForAt75 { get; set; }
        public int ShotsForAt80 { get; set; }
        public int ShotsForAt85 { get; set; }
       
    }
}
