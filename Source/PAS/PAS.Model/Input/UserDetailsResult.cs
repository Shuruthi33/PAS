using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PAS.Model.Output;

namespace PAS.Model.Input
{
    public class UserLoginResultDTO
    {
        public LoginDTO? loginDetail { get; set; }

        public List<LoginDTO> loginDetailList { get; set; }
    }
    public class UserDetailsResultDTO
    {
        public UserDetailDTO? userDetail { get; set; }

        public List<UserDetailDTO> userDetailList { get; set; }
    }
    public class ProjectDetailsResultDTO
    {
        public ProjectDTO? projectDetails { get; set; }

        public List<ProjectDTO> projectDetailsList{ get; set; }
    }

    public class MentorDetailsResultDTO
    {
        public MentorDTO? mentorDetails { get; set; }
        public List<MentorDTO> mentorDetailsList { get; set; }
    }
    public class BatchDetailsResultDTO
    {
        public BatchDTO? batchDetails { get; set; }
        public List<BatchDTO> batchDetailsList { get; set; }
    }
    public class YearDetailsResultDTO
    {
        public YearDTO? yearDetails { get; set; }

        public List<YearDTO> yearDetailsList { get; set; }
    }

    public class PrjAllotmentDetailsResultDTO
    {
        public PrjAllotmentDTO? prjAllotmentDetails { get; set; }

        public List<PrjAllotmentDTO> prjAllotmentDetailsList { get; set; }
    }


}
