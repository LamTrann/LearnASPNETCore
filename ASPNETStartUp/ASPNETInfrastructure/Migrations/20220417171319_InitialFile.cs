using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPNETInfrastructure.Migrations
{
    public partial class InitialFile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InstatTournaments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatId = table.Column<int>(type: "int", nullable: false),
                    InstatName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstatTournaments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstatTeams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatId = table.Column<int>(type: "int", nullable: false),
                    InstatName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CurrentInstatTournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstatTeams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstatTeams_InstatTournaments_CurrentInstatTournamentId",
                        column: x => x.CurrentInstatTournamentId,
                        principalTable: "InstatTournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InstatMatches",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatId = table.Column<int>(type: "int", nullable: false),
                    MatchDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    InstatHomeTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatAwayTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    HomeTeamScore = table.Column<int>(type: "int", nullable: false),
                    AwayTeamScore = table.Column<int>(type: "int", nullable: false),
                    InstatTournamentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstatMatches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstatMatches_InstatTeams_InstatAwayTeamId",
                        column: x => x.InstatAwayTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstatMatches_InstatTeams_InstatHomeTeamId",
                        column: x => x.InstatHomeTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InstatMatches_InstatTournaments_InstatTournamentId",
                        column: x => x.InstatTournamentId,
                        principalTable: "InstatTournaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstatPlayers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatPlayerId = table.Column<int>(type: "int", nullable: false),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PlayerName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstatPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InstatPlayers_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchCorners",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CornersForAt10 = table.Column<int>(type: "int", nullable: false),
                    CornersForAt20 = table.Column<int>(type: "int", nullable: false),
                    CornersForAt30 = table.Column<int>(type: "int", nullable: false),
                    CornersForAt40 = table.Column<int>(type: "int", nullable: false),
                    CornersForAt50 = table.Column<int>(type: "int", nullable: false),
                    CornersForAt60 = table.Column<int>(type: "int", nullable: false),
                    CornersForAt70 = table.Column<int>(type: "int", nullable: false),
                    CornersForAt80 = table.Column<int>(type: "int", nullable: false),
                    CornersFor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchCorners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchCorners_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchCorners_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchFouls",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FoulsForAt10 = table.Column<int>(type: "int", nullable: false),
                    FoulsForAt20 = table.Column<int>(type: "int", nullable: false),
                    FoulsForAt30 = table.Column<int>(type: "int", nullable: false),
                    FoulsForAt40 = table.Column<int>(type: "int", nullable: false),
                    FoulsForAt50 = table.Column<int>(type: "int", nullable: false),
                    FoulsForAt60 = table.Column<int>(type: "int", nullable: false),
                    FoulsForAt70 = table.Column<int>(type: "int", nullable: false),
                    FoulsForAt80 = table.Column<int>(type: "int", nullable: false),
                    FoulsFor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchFouls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchFouls_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchFouls_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchGoals",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GoalsForAt10 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt15 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt20 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt25 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt30 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt35 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt40 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt45 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt50 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt55 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt60 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt65 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt70 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt75 = table.Column<int>(type: "int", nullable: false),
                    GoalsForAt80 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchGoals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchGoals_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchGoals_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchOffsides",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OffsidesForAt10 = table.Column<int>(type: "int", nullable: false),
                    OffsidesForAt20 = table.Column<int>(type: "int", nullable: false),
                    OffsidesForAt30 = table.Column<int>(type: "int", nullable: false),
                    OffsidesForAt40 = table.Column<int>(type: "int", nullable: false),
                    OffsidesForAt50 = table.Column<int>(type: "int", nullable: false),
                    OffsidesForAt60 = table.Column<int>(type: "int", nullable: false),
                    OffsidesForAt70 = table.Column<int>(type: "int", nullable: false),
                    OffsidesForAt80 = table.Column<int>(type: "int", nullable: false),
                    OffsidesFor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchOffsides", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchOffsides_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchOffsides_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchPossession",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    OverallPossession = table.Column<double>(type: "float", nullable: false),
                    OverallPossession0to10 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession10to20 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession20to30 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession30to40 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession40to50 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession50to60 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession60to70 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession70to80 = table.Column<double>(type: "float", nullable: false),
                    OverallPossession80to90 = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchPossession", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchPossession_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchPossession_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchReds",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    RedsForAt10 = table.Column<int>(type: "int", nullable: false),
                    RedsForAt20 = table.Column<int>(type: "int", nullable: false),
                    RedsForAt30 = table.Column<int>(type: "int", nullable: false),
                    RedsForAt40 = table.Column<int>(type: "int", nullable: false),
                    RedsForAt50 = table.Column<int>(type: "int", nullable: false),
                    RedsForAt60 = table.Column<int>(type: "int", nullable: false),
                    RedsForAt70 = table.Column<int>(type: "int", nullable: false),
                    RedsForAt80 = table.Column<int>(type: "int", nullable: false),
                    RedsFor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchReds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchReds_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchReds_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchShots",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShotsForAt10 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt15 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt20 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt25 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt30 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt35 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt40 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt45 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt50 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt55 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt60 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt65 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt70 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt75 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt80 = table.Column<int>(type: "int", nullable: false),
                    ShotsForAt85 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchShots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchShots_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchShots_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchShotsInBox",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShotsInBoxForAt10 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt15 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt20 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt25 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt30 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt35 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt40 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt45 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt50 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt55 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt60 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt65 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt70 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt75 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt80 = table.Column<int>(type: "int", nullable: false),
                    ShotsInBoxForAt85 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchShotsInBox", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchShotsInBox_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchShotsInBox_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchShotsOnTarget",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShotsOnForAt10 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt15 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt20 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt25 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt30 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt35 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt40 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt45 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt50 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt55 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt60 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt65 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt70 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt75 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt80 = table.Column<int>(type: "int", nullable: false),
                    ShotsOnForAt85 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchShotsOnTarget", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchShotsOnTarget_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchShotsOnTarget_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchThrowIns",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThrowInForAt10 = table.Column<int>(type: "int", nullable: false),
                    ThrowInForAt20 = table.Column<int>(type: "int", nullable: false),
                    ThrowInForAt30 = table.Column<int>(type: "int", nullable: false),
                    ThrowInForAt40 = table.Column<int>(type: "int", nullable: false),
                    ThrowInForAt50 = table.Column<int>(type: "int", nullable: false),
                    ThrowInForAt60 = table.Column<int>(type: "int", nullable: false),
                    ThrowInForAt70 = table.Column<int>(type: "int", nullable: false),
                    ThrowInForAt80 = table.Column<int>(type: "int", nullable: false),
                    ThrowInFor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchThrowIns", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchThrowIns_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchThrowIns_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchXG",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    XgAt10 = table.Column<double>(type: "float", nullable: false),
                    XgAt15 = table.Column<double>(type: "float", nullable: false),
                    XgAt20 = table.Column<double>(type: "float", nullable: false),
                    XgAt25 = table.Column<double>(type: "float", nullable: false),
                    XgAt30 = table.Column<double>(type: "float", nullable: false),
                    XgAt35 = table.Column<double>(type: "float", nullable: false),
                    XgAt40 = table.Column<double>(type: "float", nullable: false),
                    XgAt45 = table.Column<double>(type: "float", nullable: false),
                    XgAt50 = table.Column<double>(type: "float", nullable: false),
                    XgAt55 = table.Column<double>(type: "float", nullable: false),
                    XgAt60 = table.Column<double>(type: "float", nullable: false),
                    XgAt65 = table.Column<double>(type: "float", nullable: false),
                    XgAt70 = table.Column<double>(type: "float", nullable: false),
                    XgAt75 = table.Column<double>(type: "float", nullable: false),
                    XgAt80 = table.Column<double>(type: "float", nullable: false),
                    XgAt85 = table.Column<double>(type: "float", nullable: false),
                    XgFirstHalf = table.Column<double>(type: "float", nullable: false),
                    XgSecondHalf = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchXG", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchXG_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchXG_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MatchYellows",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    YellowsForAt10 = table.Column<int>(type: "int", nullable: false),
                    YellowsForAt20 = table.Column<int>(type: "int", nullable: false),
                    YellowsForAt30 = table.Column<int>(type: "int", nullable: false),
                    YellowsForAt40 = table.Column<int>(type: "int", nullable: false),
                    YellowsForAt50 = table.Column<int>(type: "int", nullable: false),
                    YellowsForAt60 = table.Column<int>(type: "int", nullable: false),
                    YellowsForAt70 = table.Column<int>(type: "int", nullable: false),
                    YellowsForAt80 = table.Column<int>(type: "int", nullable: false),
                    YellowsFor = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MatchYellows", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MatchYellows_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MatchYellows_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerMatchDetails",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatPlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Start = table.Column<bool>(type: "bit", nullable: false),
                    Sub = table.Column<bool>(type: "bit", nullable: false),
                    GoalsScored = table.Column<int>(type: "int", nullable: false),
                    RedCards = table.Column<int>(type: "int", nullable: false),
                    YellowCards = table.Column<int>(type: "int", nullable: false),
                    MinutesPlayed = table.Column<double>(type: "float", nullable: false),
                    InstatPositionId = table.Column<int>(type: "int", nullable: false),
                    ShirtNumber = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerMatchDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerMatchDetails_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerMatchDetails_InstatPlayers_InstatPlayerId",
                        column: x => x.InstatPlayerId,
                        principalTable: "InstatPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerMatchDetails_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlayerMatchRatings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    InstatMatchId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatTeamId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatPlayerId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    InstatSeasonId = table.Column<int>(type: "int", nullable: false),
                    PlayerRating = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerMatchRatings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerMatchRatings_InstatMatches_InstatMatchId",
                        column: x => x.InstatMatchId,
                        principalTable: "InstatMatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerMatchRatings_InstatPlayers_InstatPlayerId",
                        column: x => x.InstatPlayerId,
                        principalTable: "InstatPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PlayerMatchRatings_InstatTeams_InstatTeamId",
                        column: x => x.InstatTeamId,
                        principalTable: "InstatTeams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InstatMatches_InstatAwayTeamId",
                table: "InstatMatches",
                column: "InstatAwayTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_InstatMatches_InstatHomeTeamId",
                table: "InstatMatches",
                column: "InstatHomeTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_InstatMatches_InstatTournamentId",
                table: "InstatMatches",
                column: "InstatTournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_InstatPlayers_InstatTeamId",
                table: "InstatPlayers",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_InstatTeams_CurrentInstatTournamentId",
                table: "InstatTeams",
                column: "CurrentInstatTournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchCorners_InstatMatchId",
                table: "MatchCorners",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchCorners_InstatTeamId",
                table: "MatchCorners",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchFouls_InstatMatchId",
                table: "MatchFouls",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchFouls_InstatTeamId",
                table: "MatchFouls",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchGoals_InstatMatchId",
                table: "MatchGoals",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchGoals_InstatTeamId",
                table: "MatchGoals",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchOffsides_InstatMatchId",
                table: "MatchOffsides",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchOffsides_InstatTeamId",
                table: "MatchOffsides",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPossession_InstatMatchId",
                table: "MatchPossession",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchPossession_InstatTeamId",
                table: "MatchPossession",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchReds_InstatMatchId",
                table: "MatchReds",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchReds_InstatTeamId",
                table: "MatchReds",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchShots_InstatMatchId",
                table: "MatchShots",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchShots_InstatTeamId",
                table: "MatchShots",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchShotsInBox_InstatMatchId",
                table: "MatchShotsInBox",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchShotsInBox_InstatTeamId",
                table: "MatchShotsInBox",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchShotsOnTarget_InstatMatchId",
                table: "MatchShotsOnTarget",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchShotsOnTarget_InstatTeamId",
                table: "MatchShotsOnTarget",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchThrowIns_InstatMatchId",
                table: "MatchThrowIns",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchThrowIns_InstatTeamId",
                table: "MatchThrowIns",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchXG_InstatMatchId",
                table: "MatchXG",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchXG_InstatTeamId",
                table: "MatchXG",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchYellows_InstatMatchId",
                table: "MatchYellows",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_MatchYellows_InstatTeamId",
                table: "MatchYellows",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchDetails_InstatMatchId",
                table: "PlayerMatchDetails",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchDetails_InstatPlayerId",
                table: "PlayerMatchDetails",
                column: "InstatPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchDetails_InstatTeamId",
                table: "PlayerMatchDetails",
                column: "InstatTeamId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchRatings_InstatMatchId",
                table: "PlayerMatchRatings",
                column: "InstatMatchId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchRatings_InstatPlayerId",
                table: "PlayerMatchRatings",
                column: "InstatPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerMatchRatings_InstatTeamId",
                table: "PlayerMatchRatings",
                column: "InstatTeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MatchCorners");

            migrationBuilder.DropTable(
                name: "MatchFouls");

            migrationBuilder.DropTable(
                name: "MatchGoals");

            migrationBuilder.DropTable(
                name: "MatchOffsides");

            migrationBuilder.DropTable(
                name: "MatchPossession");

            migrationBuilder.DropTable(
                name: "MatchReds");

            migrationBuilder.DropTable(
                name: "MatchShots");

            migrationBuilder.DropTable(
                name: "MatchShotsInBox");

            migrationBuilder.DropTable(
                name: "MatchShotsOnTarget");

            migrationBuilder.DropTable(
                name: "MatchThrowIns");

            migrationBuilder.DropTable(
                name: "MatchXG");

            migrationBuilder.DropTable(
                name: "MatchYellows");

            migrationBuilder.DropTable(
                name: "PlayerMatchDetails");

            migrationBuilder.DropTable(
                name: "PlayerMatchRatings");

            migrationBuilder.DropTable(
                name: "InstatMatches");

            migrationBuilder.DropTable(
                name: "InstatPlayers");

            migrationBuilder.DropTable(
                name: "InstatTeams");

            migrationBuilder.DropTable(
                name: "InstatTournaments");
        }
    }
}
