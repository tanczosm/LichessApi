using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using LichessApi.Web;
using LichessApi.Web.Api.Games.Request;

namespace LichessApi
{
    public static class LichessApiConstants
    {
        public static class EndPoints
        {
            static private readonly URIParameterFormatProvider _provider = new();

            // Account
            public static Uri GetMyProfile()        => EUri($"/api/account");
            public static Uri GetMyEmailAddress()   => EUri($"/api/account/email");
            public static Uri GetMyPreferences()    => EUri($"/api/account/preferences"); 
            public static Uri GetMyKidModeStatus()  => EUri($"/api/account/kid");
            public static Uri SetMyKidModeStatus()  => EUri($"/api/account/kid");

            // Users
            public static Uri GetRealtimeUsersStatus() => EUri($"/api/users/status");
            public static Uri GetAllTopTen()           => EUri($"/player");
            public static Uri GetUsersById()           => EUri($"/api/users");
            public static Uri GetLiveStreamers()       => EUri($"/streamer/live");
            public static Uri GetOneLeaderboard(string nb, string perfType) => EUri($"/player/top/{nb}/{perfType}");
            public static Uri GetPublicUserData(string username)        => EUri($"/api/user/{username}");
            public static Uri GetUserRatingHistory(string username)     => EUri($"/api/user/{username}/rating-history");
            public static Uri GetUserActivity(string username)          => EUri($"/api/user/{username}/activity");
            public static Uri GetTeamMembers(string teamId)             => EUri($"/api/team/{teamId}/users");
            public static Uri GetCrosstable(string user1, string user2) => EUri($"/api/crosstable/{user1}/{user2}");

            // Relations
            public static Uri GetUsersFollowed(string username)         => EUri($"/api/user/{username}/following");
            public static Uri GetUsersWhoFollowUser(string username)         => EUri($"/api/user/{username}/followers");

            // Games
            public static Uri ExportOneGame(string gameId)       => EUri($"/game/export/{gameId}");
            public static Uri ExportOngoingGame(string username) => EUri($"/api/user/{username}/current-game");
            public static Uri ExportGamesByUser(string username) => EUri($"/api/games/user/{username}");
            public static Uri ExportGamesByIds()       => EUri($"/games/export/_ids");
            public static Uri StreamCurrentGames()     => EUri($"/api/stream/games-by-users");
            public static Uri GetOngoingGames()        => EUri($"/api/account/playing");
            public static Uri GetCurrentTvGames()      => EUri($"/tv/channels");
            public static Uri StreamCurrentTvGame()    => EUri($"/tv/feed");
            public static Uri ImportOneGame()          => EUri($"/api/import");

            // Puzzles
            public static Uri GetPuzzleActivity()      => EUri($"/api/puzzle/activity");
            public static Uri GetPuzzleDashboard(string days)  => EUri($"/api/puzzle/dashboard/{days}");

            // Teams
            public static Uri GetTeamSwissTournaments(string teamId) => EUri($"/api/team/{teamId}/swiss");
            public static Uri GetSingleTeam(string teamId)           => EUri($"/api/team/{teamId}");
            public static Uri GetPopularTeams()                      => EUri($"/api/team/all");
            public static Uri TeamsOfPlayer(string username)         => EUri($"/api/team/of/{username}");
            public static Uri SearchTeams()                          => EUri($"/api/team/search");
            public static Uri GetTeamArenaTournaments(string teamId) => EUri($"/api/team/{teamId}/arena");
            public static Uri JoinTeam(string teamId)                => EUri($"/team/{teamId}/join");
            public static Uri LeaveTeam(string teamId)               => EUri($"/team/{teamId}/quit");
            public static Uri KickTeamUser(string teamId, string userId) => EUri($"/team/{teamId}/kick/{userId}");
            public static Uri MessageAllMembers(string teamId)       => EUri($"/team/{teamId}/pm-all");

            // Board
            public static Uri StreamIncomingEvents()                => EUri($"/api/stream/event");
            public static Uri CreateASeek()                         => EUri($"/api/board/seek");
            public static Uri StreamBoardGameState(string gameId)   => EUri($"/api/board/game/stream/{gameId}");
            public static Uri MakeABoardMove(string gameId, string move) => EUri($"/api/board/game/{gameId}/move/{move}");
            public static Uri WriteInChat(string gameId)            => EUri($"/api/board/game/{gameId}/chat");
            public static Uri AbortGame(string gameId)              => EUri($"/api/board/game/{gameId}/abort");
            public static Uri ResignGame(string gameId)             => EUri($"/api/board/game/{gameId}/resign");
            public static Uri HandleDrawOffers(string gameId, string accept) => EUri($"/api/board/game/{gameId}/draw/{accept}");

            // Bot
            public static Uri UpgradeToBotAccount() => EUri($"/api/bot/account/upgrade");
            public static Uri StreamBotGameState(string gameId) => EUri($"/api/bot/game/stream/{gameId}");
            public static Uri MakeBotMove(string gameId, string move) => EUri($"/api/bot/game/{gameId}/move/{move}");
            public static Uri WriteInBotChat(string gameId) => EUri($"/api/bot/game/{gameId}/chat");
            public static Uri AbortBotGame(string gameId) => EUri($"/api/bot/game/{gameId}/abort");
            public static Uri ResignBotGame(string gameId) => EUri($"/api/bot/game/{gameId}/resign");

            // Bulk pairings
            public static Uri ViewUpcomingBulkPairings() => EUri($"/api/bulk-pairing");
            public static Uri CreateBulkPairing() => EUri($"/api/bulk-pairing");
            public static Uri CancelBulkPairing(string bulkPairingId) => EUri($"/ap/bulk-pairing/{bulkPairingId}");

            // Challenges
            public static Uri CreateChallenge(string username) => EUri($"/api/challenge/{username}");
            public static Uri AcceptChallenge(string challengeId) => EUri($"/api/challenge/{challengeId}/accept");
            public static Uri DeclineChallenge(string challengeId) => EUri($"/api/challenge/{challengeId}/decline");
            public static Uri CancelChallenge(string challengeId) => EUri($"/api/challenge/{challengeId}/cancel");
            public static Uri ChallengeAI() => EUri($"/api/challenge/ai");
            public static Uri OpenEndedChallenge() => EUri($"/api/challenge/open");
            public static Uri StartClocks(string gameId) => EUri($"/api/challenge/{gameId}/start-clocks");
            public static Uri AddTimeToOpponentClock(string gameId, string seconds) => EUri($"/api/round/{gameId}/add-time/{seconds}");
            public static Uri CreateAdminChallenge(string orig, string dest) => EUri($"/api/challenge/admin/{orig}/{dest}");
            
            // Arena Tournaments
            public static Uri GetCurrentTournaments() => EUri($"/api/tournament");
            public static Uri CreateArenaTournament() => EUri($"/api/tournament");
            public static Uri UpdateTeamBattle(string tournamentId) => EUri($"/api/tournament/team-battle/{tournamentId}"); 
            public static Uri GetTournamentInfo(string tournamentId) => EUri($"/api/tournament/{tournamentId}");
            public static Uri ExportArenaTournamentGames(string tournamentId) => EUri($"/api/tournament/{tournamentId}/games");
            public static Uri GetArenaTournamentResults(string tournamentId) => EUri($"/api/tournament/{tournamentId}/results");
            public static Uri GetTeamBattleStanding(string tournamentId) => EUri($"/api/tournament/{tournamentId}/teams");
            public static Uri GetTournamentsCreatedByUser(string username) => EUri($"/api/user/{username}/tournament/created");

            // Swiss Tournaments
            public static Uri CreateSwissTournament (string teamId) => EUri($"/api/swiss/new/{teamId}");
            public static Uri ExportSwissTournamentTRF(string tournamentId) => EUri($"/swiss/{tournamentId}.trf");
            public static Uri ExportSwissTournamentGames(string tournamentId) => EUri($"/api/swiss/{tournamentId}/games");
            public static Uri ExportSwissTournamentResults(string tournamentId) => EUri($"/api/swiss/{tournamentId}/results");

            // Simuls
            public static Uri GetCurrentSimuls() => EUri($"/api/simul");

            // Studies
            public static Uri ExportOneStudyChapter(string studyId, string chapterId) => EUri($"/study/{studyId}/{chapterId}.pgn");
            public static Uri ExportAllChapters(string studyId) => EUri($"/study/{studyId}.pgn");

            // Messaging
            public static Uri SendPrivateMessage(string username) => EUri($"/inbox/{username}");

            // Broadcasts
            public static Uri GetOfficialBroadcasts() => EUri($"/api/broadcast");
            public static Uri CreateBroadcast() => EUri($"/broadcast/new");
            public static Uri GetYourBroadcast(string slug, string broadcastId) => EUri($"/broadcast/{slug}/{broadcastId}");
            public static Uri UpdateBroadcast(string slug, string broadcastId) => EUri($"/broadcast/{slug}/{broadcastId}/edit");
            public static Uri PushPGNToYourBroadcast(string slug, string broadcastId) => EUri($"/broadcast/{slug}/{broadcastId}/push");

            // Analysis
            public static Uri GetCloudEvaluationOfPosition(string fen, int multiPv = 1, string variant = "standard") => EUri($"/api/cloud-eval");

            private static Uri EUri(FormattableString path) => new(path.ToString(_provider), UriKind.Relative);
        }

        /// <summary>
        /// Lichess API Scopes
        /// <para>https://lichess.org/api#section/Authentication</para>
        /// </summary>
        public static class Scopes
        {
            /// <summary>
            /// Read your preferences
            /// </summary>
            public const string PreferencesRead = "preference:read";

            /// <summary>
            /// Write your preferences
            /// </summary>
            public const string PreferencesWrite = "preference:write";

            /// <summary>
            /// Read your email address
            /// </summary>
            public const string EmailRead = "email:read";

            /// <summary>
            /// Read incoming challenges
            /// </summary>
            public const string ChallengeRead = "challenge:read";

            /// <summary>
            /// Create, accept, decline challenges
            /// </summary>
            public const string ChallengeWrite = "challenge:write";

            /// <summary>
            /// Create or delete bulk challenges
            /// </summary>
            public const string ChallengeBulk = "challenge:bulk";

            /// <summary>
            /// Read private studies and broadcasts
            /// </summary>
            public const string StudyRead = "study:read";

            /// <summary>
            /// Create, update, delete studies and broadcasts
            /// </summary>
            public const string StudyWrite = "study:write";

            /// <summary>
            /// Create tournaments
            /// </summary>
            public const string TournamentWrite = "tournament:write";

            /// <summary>
            /// Read puzzle activity
            /// </summary>
            public const string PuzzleRead = "puzzle:read";

            /// <summary>
            /// Join, leave, and manage teams
            /// </summary>
            public const string TeamWrite = "team:write";

            /// <summary>
            /// Send private messages to other players
            /// </summary>
            public const string MessageWrite = "msg:write";

            /// <summary>
            /// Play with the Board API
            /// </summary>
            public const string BoardPlay = "board:play";

            /// <summary>
            /// Play with the Bot API.  Only for Bot Accounts.
            /// </summary>
            public const string BotPlay = "bot:play";
        }
    }
}
