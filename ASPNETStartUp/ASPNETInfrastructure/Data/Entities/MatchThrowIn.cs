using ASPNETInfrastructure.Data.Abstractions;
using System;

namespace ASPNETInfrastructure.Entities
{
    public class MatchThrowIn : BaseEntity<Guid>
    {
        public virtual InstatMatch InstatMatch { get; set; }
        public virtual InstatTeam InstatTeam { get; set; }
        public int ThrowInForAt10 { get; set; }
        public int ThrowInForAt20 { get; set; }
        public int ThrowInForAt30 { get; set; }
        public int ThrowInForAt40 { get; set; }
        public int ThrowInForAt50 { get; set; }
        public int ThrowInForAt60 { get; set; }
        public int ThrowInForAt70 { get; set; }
        public int ThrowInForAt80 { get; set; }
        public int ThrowInFor { get; set; }
    }
}
