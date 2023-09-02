using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAS.Framework
{
    public class StroredProc
    {
        public class UserController
        {
            public const string GetUserInfo = "GetUserInfo";
            public const string GetUserById = "GetUserById";
            public const string DeleteUserInfo = "DeleteUserInfo";
            public const string SaveUserInfo = "SaveUserInfo";
        }

        public class ProjectController
        {
            public const string GetPrjInfo = "GetPrjInfo";
            public const string GetPrjById = "GetPrjById";
            public const string DeletePrjInfo = "DeletePrjInfo";
            public const string SaveProjectInfo = "SaveProjectInfo";
        }

        public class MentorController
        {
            public const string GetMentorInfo = "GetMentorInfo";
            public const string GetMentorById = "GetMentorById";
            public const string SaveMentorInfo = "SaveMentorInfo";
            public const string DeleteMentorInfo = "DeleteMentorInfo";

        }

        public class BatchController
        {
            public const string GetBatchInfo = "GetBatchInfo";
            public const string GetBatchById = "GetBatchById";
            public const string SaveBatchInfo = "SaveBatchInfo";
            public const string DeleteBatchInfo = "DeleteBatchInfo";
        }

        public class YearController
        {
            public const string GetYearInfo = "GetYearInfo";
            public const string GetYearById = "GetYearById";
            public const string SaveYearInfo = "SaveYearInfo";
            public const string DeleteYearInfo = "DeleteYearInfo";

        }
        public class PrjAllotmentController
        {
            public const string GetPrjAlloment = "GetPrjAlloment";
            public const string PrjAllocatedById = "PrjAllocatedById";
            public const string SavePrjAllocatedInfo = "SavePrjAllocatedInfo";
            public const string DeletePrjAllocatedInfo = "DeletePrjAllocatedInfo";

        }
    }
}
