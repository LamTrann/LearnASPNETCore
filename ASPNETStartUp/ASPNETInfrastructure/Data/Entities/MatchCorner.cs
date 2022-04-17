using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class MatchCorner : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int CornersForAt10 { get; set; }
        public int CornersForAt20 { get; set; }
        public int CornersForAt30 { get; set; }
        public int CornersForAt40 { get; set; }
        public int CornersForAt50 { get; set; }
        public int CornersForAt60 { get; set; }
        public int CornersForAt70 { get; set; }
        public int CornersForAt80 { get; set; }
        public int CornersFor { get; set; }
    }
}
