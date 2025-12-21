using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_APP.Models
{
    internal class ClassSession
    {
        public int SessionID { get; set; }
        public string ClassName { get; set; }
        public Trainer AssignedTrainer { get; set; }
        public DateTime ScheduleTime { get; set; }
        public int MaxSlots { get; set; }
        public string GenderGroup { get; set; }       
        public List<Member> BookedMembers { get; set; } = new List<Member>();
    }
}
