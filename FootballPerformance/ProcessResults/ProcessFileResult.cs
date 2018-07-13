using FootballPerformance.ImportEngine.Records;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballPerformance.ProcessResults
{
    /// <summary>
    /// Class to evaluate the data records
    /// </summary>
    public static class ProcessFileResult
    {
        /// <summary>
        /// method to get the name of team with minimum difference in For and Against goals.
        /// </summary>
        /// <param name="recordsReaded">list of records</param>
        /// <returns>name of the team</returns>
        public static string GetBestPerformer(List<DataRecord> recordsReaded)
        {
            string bestPerformerTeamName = recordsReaded.OrderBy(team =>Math.Abs(team.F - team.A)).FirstOrDefault().TeamName;
            return bestPerformerTeamName;
        }
    }
}
