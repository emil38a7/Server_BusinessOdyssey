using System;
using System.Collections.Generic;

namespace Server_BusinessOdyssey.Models
{
    public partial class ScoreSheetReg
    {
        public int ScoreSheetRegId { get; set; }
        public int SGroupId { get; set; }
        public int? JGroupId { get; set; }
        public double? Points { get; set; }
        public int TrackId { get; set; }

        public StudentGroup SGroup { get; set; }
        public Track Track { get; set; }
    }
}
