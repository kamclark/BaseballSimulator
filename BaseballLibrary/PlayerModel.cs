using System;

namespace BaseballLibrary
{
    /// <summary>
    /// Player ratings, bio information and statistics attained
    /// </summary>
    public class PlayerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Nickname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ContactRating { get; set; }
        public int PowerRating { get; set; }
        public int SpeedRating { get; set; }
        public int EyeRating { get; set; }
        public int HiddenRating { get; set; }
        public int SkillPoints { get; set; }
        public string Position { get; set; }
        public string PositionAbbreviation { get; set; }
        public bool ActivePlayer { get; set; }
        public int Id { get; set; }

        // since these are stats/results they are read only
        public int Singles { get; }
        public int Homeruns { get; }
        public int Strikeouts { get; }
        public int Outs { get; }
        public float BattingAverage { get; set; }
    }
}
