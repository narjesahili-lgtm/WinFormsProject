using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_APP.Models
{
    internal class Member
    {
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string MembershipType { get; set; }   
        public bool IsActive { get; set; }
        public string Gender { get; set; }
    }
}
