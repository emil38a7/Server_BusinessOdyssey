using System;
using System.Collections.Generic;

namespace Server_BusinessOdyssey.Models
{
    public partial class Judge
    {
        public int JudgeId { get; set; }
        public string JudgeName { get; set; }
        public int JGroupId { get; set; }

        public JudgesGroup JGroup { get; set; }
    }
}
