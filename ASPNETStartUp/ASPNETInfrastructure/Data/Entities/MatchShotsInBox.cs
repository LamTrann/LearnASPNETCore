using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchShotsInBox : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int ShotsInBoxForAt10 { get; set; }
        public int ShotsInBoxForAt15 { get; set; }
        public int ShotsInBoxForAt20 { get; set; }
        public int ShotsInBoxForAt25 { get; set; }
        public int ShotsInBoxForAt30 { get; set; }
        public int ShotsInBoxForAt35 { get; set; }
        public int ShotsInBoxForAt40 { get; set; }
        public int ShotsInBoxForAt45 { get; set; }
        public int ShotsInBoxForAt50 { get; set; }
        public int ShotsInBoxForAt55 { get; set; }
        public int ShotsInBoxForAt60 { get; set; }
        public int ShotsInBoxForAt65 { get; set; }
        public int ShotsInBoxForAt70 { get; set; }
        public int ShotsInBoxForAt75 { get; set; }
        public int ShotsInBoxForAt80 { get; set; }
        public int ShotsInBoxForAt85 { get; set; }
       
    }
}
