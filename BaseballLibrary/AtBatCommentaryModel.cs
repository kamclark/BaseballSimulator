using System.Collections.Generic;

namespace BaseballLibrary
{
    public class AtBatCommentaryModel
    {
        public List<string> RandomFacts { get; set; }
        public List<string> MilestoneWarnings { get; set; }
        public List<string> MilestonesHit { get; set; }
        public List<string> SingleResults { get; set; }
        public List<string> HomerunResults { get; set; }
        public List<string> GroundoutResults { get; set; }
        public List<string> StrikeoutResults { get; set; }

        // TODO -- Connect model to .txt file for commentary


    }
}
