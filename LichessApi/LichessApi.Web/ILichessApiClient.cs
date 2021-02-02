using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web.Api.Account;
using LichessApi.Web.Api.Analysis;
using LichessApi.Web.Api.ArenaTournaments;
using LichessApi.Web.Api.Board;
using LichessApi.Web.Api.Bot;
using LichessApi.Web.Api.Broadcasts;
using LichessApi.Web.Api.Challenges;
using LichessApi.Web.Api.Games;
using LichessApi.Web.Api.Messaging;
using LichessApi.Web.Api.Puzzles;
using LichessApi.Web.Api.Relations;
using LichessApi.Web.Api.Simuls;
using LichessApi.Web.Api.Studies;
using LichessApi.Web.Api.SwissTournaments;
using LichessApi.Web.Api.Teams;
using LichessApi.Web.Api.Users;
using LichessApi.Web.Api.BulkPairings;
using LichessApi.Web.Http;

#pragma warning disable CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
namespace LichessApi.Web
{
    public interface ILichessApiClient
    {
        // Configuration properties
        LichessApiClientConfig Configuration { get; init; }

        // Apis
        IAccount Account { get; }
        IAnalysis Analysis { get; }
        IArenaTournaments ArenaTournaments { get; }
        IBoard Board { get; }
        IBot Bot { get; }
        IBroadcasts Broadcasts { get; }
        IBulkPairings BulkPairings { get;  }
        IChallenges Challenges { get; }
        IGames Games { get; }
        IMessaging Messaging { get; }
        IPuzzles Puzzles { get; }
        IRelations Relations { get; }
        ISimuls Simuls { get; }
        IStudies Studies { get; }
        ISwissTournaments SwissTournaments { get; }
        ITeams Teams { get; }
        IUsers Users { get; }
        IResponse? LastResponse { get; }
    }
}
#pragma warning restore CS8632 // The annotation for nullable reference types should only be used in code within a '#nullable' annotations context.
