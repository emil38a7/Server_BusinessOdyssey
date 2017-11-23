using System;
using System.Collections.Generic;

namespace Server_BusinessOdyssey.Models
{
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentSchool { get; set; }
        public int SGroupId { get; set; }

        public StudentGroup SGroup { get; set; }
    }
}
