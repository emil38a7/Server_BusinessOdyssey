using System;
using System.Collections.Generic;

namespace Server_BusinessOdyssey.Models
{
    public partial class ScheduleMaster
    {
        public int ScheduleMasterId { get; set; }
        public int JGroupId { get; set; }
        public int SGroupId { get; set; }
        public int ScheduleId { get; set; }

        public JudgesGroup JGroup { get; set; }
        public StudentGroup SGroup { get; set; }
        public Schedule Schedule { get; set; }
    }
}
