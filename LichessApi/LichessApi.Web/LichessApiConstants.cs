using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LichessApi
{
    public static class LichessApiConstants
    {
        public static class EndPoints
        {
            // Account
            public static readonly string GetMyProfileEndPointUrl           = "/api/account";
            public static readonly string GetMyEmailAddressEndPointUrl      = "/api/account/email";
            public static readonly string GetMyPreferencesEndPointUrl       = "/api/account/preferences"; 
            public static readonly string GetMyKidModeStatusEndPointUrl     = "/api/account/kid";
            public static readonly string SetMyKidModeStatusEndPointUrl     = "/api/account/kid";

            // Users
            public static readonly string GetRealtimeUsersStatusEndPointUrl = "/api/users/status";
            public static readonly string GetAllTopTenEndPointUrl           = "/player";
            public static readonly string GetOneLeaderboardEndPointUrl      = "/player/top/{nb}/{perfType}";
            public static readonly string GetPublicUserDataEndPointUrl      = "/api/user/{username}";
            public static readonly string GetUserRatingHistoryEndPointUrl   = "/api/user/{username}/rating-history";
            public static readonly string GetUserActivityEndPointUrl        = "/api/user/{username}/activity";
            public static readonly string GetUsersByIdEndPointUrl           = "/api/users";
            public static readonly string GetTeamMembersEndPointUrl         = "/api/team/{teamId}/users";
            public static readonly string GetLiveStreamersEndPointUrl       = "/streamer/live";
            public static readonly string GetCrosstableEndPointUrl          = "/api/crosstable/{user1}/{user2}";

            // Relations
            public static readonly string GetUsersFollowedEndPointUrl       = "/api/user/{username}/following";
            public static readonly string GetFollowedUsersEndPointUrl       = "/api/user/{username}/followers";

            // Games
            public static readonly string ExportOneGameEndPointUrl          = "/game/export/{gameId}";
            public static readonly string ExportOngoingGameEndPointUrl      = "/api/user/{username}/current-game";
            public static readonly string ExportGamesByUserEndPointUrl      = "/api/games/user/{username}";
            public static readonly string ExportGamesByIdsEndPointUrl       = "/games/export/_ids";
            public static readonly string StreamCurrentGamesEndPointUrl     = "/api/stream/games-by-users";
            public static readonly string GetOngoingGamesEndPointUrl        = "/api/account/playing";
            public static readonly string GetCurrentTvGamesEndPointUrl      = "/tv/channels";
            public static readonly string StreamCurrentTvGameEndPointUrl    = "/tv/feed";
            public static readonly string ImportOneGameEndPointUrl          = "/api/import";

            // Puzzles
            public static readonly string GetPuzzleActivityEndPointUrl      = "/api/puzzle/activity";
            public static readonly string GetPuzzleDashboardEndPointUrl     = "/api/puzzle/dashboard/{days}";

            // Teams
            public static readonly string GetTeamSwissTournamentsEndPointUrl = "/api/team/{teamId}/swiss";
            public static readonly string GetSingleTeamEndPointUrl          = "/api/team/{teamId}";
            public static readonly string GetPopularTeamsEndPointUrl        = "/api/team/all";
            public static readonly string TeamsOfPlayerEndPointUrl          = "/api/team/of/{username}";
            public static readonly string SearchTeamsEndPointUrl            = "/api/team/search";
            public static readonly string GetTeamArenaTournamentsEndPointUrl = "/api/team/{teamId}/arena";
            public static readonly string JoinTeamEndPointUrl               = "/team/{teamId}/join";
            public static readonly string LeaveTeamEndPointUrl              = "/team/{teamId}/quit";
            public static readonly string KickTeamUserEndPointUrl           = "/team/{teamId}/kick/{userId}";
            public static readonly string MessageAllMembersEndPointUrl      = "/team/{teamId}/pm-all";

            // Board
            public static readonly string StreamIncomingEventsEndPointUrl   = "/api/board/seek";
            public static readonly string CreateASeekEndPointUrl            = "/api/board/seek";
            public static readonly string StreamBoardGameStateEndPointUrl   = "/api/board/game/stream/{gameId}";
            public static readonly string MakeABoardMoveEndPointUrl         = "/api/board/game/{gameId}/move/{move}";
            public static readonly string WriteInChatEndPointUrl            = "/api/board/game/{gameId}/chat";
            public static readonly string AbortGameEndPointUrl              = "/api/board/game/{gameId}/abort";
            public static readonly string ResignGameEndPointUrl             = "/api/board/game/{gameId}/resign";
            public static readonly string HandleDrawOffersEndPointUrl       = "/api/board/game/{gameId}/draw/{accept}";

            // Bot
            // TODO

            // Challenges
            public static readonly string CreateChallengeEndPointUrl        = "/api/challenge/{username}";
            public static readonly string AcceptChallengeEndPointUrl        = "/api/challenge/{challendId}/accept";
            public static readonly string DeclineChallengeEndPointUrl       = "/api/challenge/{challengeId}/decline";
            public static readonly string CancelChallengeEndPointUrl        = "/api/challenge/{challengeId}/cancel";
            public static readonly string ChallengeAIEndPointUrl            = "/api/challenge/ai";
            public static readonly string OpenEndedChallengeEndPointUrl     = "/api/challenge/open";
            public static readonly string StartClocksEndPointUrl            = "/api/challenge/{gameId}/start-clocks";
            public static readonly string AddTimeToOpponentClockEndPointUrl = "/api/round/{gameId}/add-time/{seconds}";
            public static readonly string CreateAdminChallengeEndPointUrl   = "/api/challenge/admin/{orig}/{dest}";
            
            // Arena Tournaments
            // TODO

            // Swiss Tournaments
            // TODO

            // Simuls
            // TODO

            // Studies
            // TODO

            // Messaging
            public static readonly string SendPrivateMessageEndPointUrl = "/inbox/{username}";

            // Broadcasts
            public static readonly string GetOfficialBroadcastsEndPointUrl  = "/api/broadcast";
            public static readonly string CreateBroadcastEndPointUrl        = "/broadcast/new";
            public static readonly string GetYourBroadcastEndPointUrl       = "/broadcast/{slug}/{broadcastId}";
            public static readonly string UpdateBroadcastEndPointUrl        = "/broadcast/{slug}/{broadcastId}/edit";
            public static readonly string PushPGNToYourBroadcastEndPointUrl = "/broadcast/{slug}/{broadcastId}/push";

            // Analysis
            // TODO
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
