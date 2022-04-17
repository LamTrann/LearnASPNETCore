using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchPossession : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public double OverallPossession { get; set; }
        public double OverallPossession0to10 { get; set; }
        public double OverallPossession10to20 { get; set; }
        public double OverallPossession20to30 { get; set; }
        public double OverallPossession30to40 { get; set; }
        public double OverallPossession40to50 { get; set; }
        public double OverallPossession50to60 { get; set; }
        public double OverallPossession60to70 { get; set; }
        public double OverallPossession70to80 { get; set; }
        public double OverallPossession80to90 { get; set; }

    }
}
