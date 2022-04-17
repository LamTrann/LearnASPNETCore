using ASPNETInfrastructure.Data.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETInfrastructure.Entities
{
    public class InstatMatch : BaseEntity<Guid>
    {
        public int InstatId { get; set; }
        public DateTime MatchDate { get; set; }
        public virtual InstatTeam InstatHomeTeam { get; set; }
        public virtual InstatTeam InstatAwayTeam { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
        public Guid InstatTournamentId { get; set; }
        public virtual InstatTournament Tournament { get; set; }
    }
}
