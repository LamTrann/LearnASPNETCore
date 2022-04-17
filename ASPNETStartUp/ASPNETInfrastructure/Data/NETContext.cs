using ASPNETInfrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ASPNETInfrastructure.Data
{
    public class NETContext : DbContext
    {
        public NETContext(DbContextOptions<NETContext> options) : base(options)
        {

        }

        public DbSet<InstatTeam> InstatTeams { get; set; }
        public DbSet<InstatMatch> InstatMatches { get; set; }
        public DbSet<InstatTournament> InstatTournaments { get; set; }
        public DbSet<InstatPlayer> InstatPlayers { get; set; }
        public DbSet<MatchXG> MatchXG { get; set; }
        public DbSet<MatchGoal> MatchGoals { get; set; }
        public DbSet<MatchShot> MatchShots { get; set; }
        public DbSet<MatchShotsOnTarget> MatchShotsOnTarget { get; set; }
        public DbSet<MatchShotsInBox> MatchShotsInBox { get; set; }
        public DbSet<MatchCorner> MatchCorners { get; set; }
        public DbSet<MatchYellow> MatchYellows { get; set; }
        public DbSet<MatchRed> MatchReds { get; set; }
        public DbSet<MatchFoul> MatchFouls { get; set; }
        public DbSet<MatchOffside> MatchOffsides { get; set; }
        public DbSet<MatchThrowIn> MatchThrowIns { get; set; }
        public DbSet<MatchPossession> MatchPossession { get; set; }
        public DbSet<PlayerMatchDetail> PlayerMatchDetails { get; set; }
        public DbSet<PlayerMatchRating> PlayerMatchRatings { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
