using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchXG : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public double XgAt10 { get; set; }
        public double XgAt15 { get; set; }
        public double XgAt20 { get; set; }
        public double XgAt25 { get; set; }
        public double XgAt30 { get; set; }
        public double XgAt35 { get; set; }
        public double XgAt40 { get; set; }
        public double XgAt45 { get; set; }
        public double XgAt50 { get; set; }
        public double XgAt55 { get; set; }
        public double XgAt60 { get; set; }
        public double XgAt65 { get; set; }
        public double XgAt70 { get; set; }
        public double XgAt75 { get; set; }
        public double XgAt80 { get; set; }
        public double XgAt85 { get; set; }
        public double XgFirstHalf { get; set; }
        public double XgSecondHalf { get; set; }
       
    }
}
