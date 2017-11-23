using System;
using System.Collections.Generic;

namespace Server_BusinessOdyssey.Models
{
    public partial class Track
    {
        public Track()
        {
            ScoreSheet = new HashSet<ScoreSheet>();
            ScoreSheetReg = new HashSet<ScoreSheetReg>();
        }

        public int TrackId { get; set; }
        public string TrackName { get; set; }

        public ICollection<ScoreSheet> ScoreSheet { get; set; }
        public ICollection<ScoreSheetReg> ScoreSheetReg { get; set; }
    }
}
