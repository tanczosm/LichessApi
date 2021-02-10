using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using LichessApi.Web.Api.Puzzles.Response;
using LichessApi.Web.Models;
using LichessApi.Web.Entities;
using LichessApi.Web.Http;

namespace LichessApi.Web.Api.Puzzles
{
    public interface IPuzzles
    {
        void Initialize(IApiConnector api);
        IAsyncEnumerable<PuzzleActivity> GetPuzzleActivity(int maxPuzzles = 0, CancellationToken token = default);
        Task<PuzzleDashboardResponse> GetPuzzleDashboard(int days = 1);
    }
}