using System;

namespace BaseballLibrary
{
    /// <summary>
    /// Bounds of all at bat outcomes and randomly generated at bat result
    /// </summary>
    public class AtBatResultModel
    {
        // =============== symbolic constants ===================
        private const int RATING_INCREASE_MULTIPLIER = 4000; // 

        private const int TRIPLE_PROBABILITY_BOUND = 4607745;  // 
        private const int HITBYPITCH_PROBABILITY_BOUND = 8466822; //
        private const int HR_PROBABILITY_BOUND = 24921245; //
        private const int DOUBLE_PROBABILITY_BOUND = 44522245; // 
        private const int WALK_PROBABILITY_BOUND = 78427508; // 
        private const int SINGLE_PROBABILITY_BOUND = 153353997; //
        private const int STRIKEOUT_PROBABILITY_BOUND = 199964917; //
        private const int OUT_PROBABILITY_BOUND = 494202343; //- (RATING_INCREASE_MULTIPLIER * 2);



        // =============== instance members =====================
        public int AtBatResult { get; set; }

        /// <summary>
        /// Simulates batter's at bat with randomized result
        /// </summary>
        /// <returns>Result achieved for hitter </returns>
        public int NewAtBat()
        {
            Random randomNumber = new Random();
            AtBatResult = randomNumber.Next(10); // random int 0 - 9

            if (AtBatResult >=0 && AtBatResult < 3) // if random number is in range of 0 - 2
            {
                // this is a single
            }

            else if (AtBatResult >= 3 && AtBatResult < 5) 
            {
                // this is a strikeout
            }

            else if (AtBatResult == 5)
            {
                // this is a homerun
            }

            else if (AtBatResult > 5 && AtBatResult < 10)
            {
                // this is a groundout
            }

            else
            {
                // something has gone terribly wrong
            }

            return AtBatResult;
        }
    }
}
