using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Model.Output
{
    public class LoginDTO
    {
        public string? UserName { get; set; }
        public string? Password { get; set; }

    }
    public class UserDetailDTO
    {
        public int UserId { get; set; } = 0;
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }

        public DateTime RegDate { get; set; }
        public DateTime? DOB { get; set; }
        public int GenderId { get; set; }
        public int MobileNo { get; set; }
        public string? Qualification { get; set; }
        public string? Specialization { get; set; }
       public int YearId { get; set; }
        public int BatchId { get; set; }
        public int? RoleId { get; set; }

    }

    public class ProjectDTO
    {
        public int PrjId { get; set; } = 0;
        public string? PrjTitle { get; set; }
        public string? PrjScope { get; set; }
        public string? PrjFuture { get; set; }
        public string? PrjAnnouncement { get; set; }
    }

    public class MentorDTO
    {
        public int MentorId { get; set; } = 0;
        public string? Name { get; set; }
        public string?  Email { get; set; }
        public int MobileNo { get; set; }

       
    }

    public class BatchDTO
    {
        public int BatchId { get; set; } = 0;
        public string? BatchName { get; set; }
        public int YearId { get; set; }
 
        public string? StartDate { get; set; }
        public string? EndDate { get; set; }
    }

    public class YearDTO
    {
        public int YearId { get; set; } = 0;
        public string? YearName { get; set; }
    }

    public class PrjAllotmentDTO
    {
        public int AllocatedId { get; set; } = 0;
        public int UserId { get; set; }
        public int PrjId { get; set; }
        public int MentorId { get; set; }
        public int YearId { get; set; }
        public int BathId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int StatusId { get; set; }

    }

}
