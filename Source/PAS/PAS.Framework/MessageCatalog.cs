namespace PMT.Framework
{
	public static class MessageCatalog
	{
		public static class MessageTitle
		{
			public const string UserDetails = "User Details";
			public const string UserRole = "User Role";
			public const string TeamPlan = "Team Plan";
			public const string EmployeeDetails = "EmployeeDetails";
            
        }

		public static class ErrorCodes
		{
			public const int Success = 200;
			public const int Created = 201;
			public const int Updated = 202;
			public const int Failed = 500;
			public const int Exist = 203;
			public const int AlreadyExist = -99;
			public const int NoRecordFound = 204;
			public const int Deleted = 205;
			public const int UserNameNotExists = -91;
			public const int PasswordIncorrect = -92;
			public const int UserNotFound = -93;

			public const int InValidKey = 208;
			public const int InValidToken = 210;

			public const int BadRequest = 400;
			public const int UnAuthorized = 401;
			public const int RequestTimeOut = 408;
			public const int ServiceTimeout = 440;
			public const int InvalidCredentials = 422;
			public const int PreconditionFailed = 412;
		}

		public static class ErrorMessages
		{
			public const string Success = "Success";
			public const string Failed = "Failed";
			public const string Exist = "Record Exist";
			public const string ListSuccess = "Success";
			public const string ListFailed = "Unable to get the record.";

			public const string UserNameNotExists = "Username is invalid";
			public const string PasswordIncorrect = "Password is invalid";

			public const string SaveSuccess = "Saved successfully.";
			public const string SaveFailed = "Unable to save record.";

			public const string DeleteSuccess = "Deleted successfully.";
			public const string DeleteFailed = "Unable to delete the record.";

			public const string NoRecordFound = "No record found";
			public const string RecordReferred = "Record referred";

			public const string InValidKey = "Invalid key";
			public const string ParmeterRequied = "Parameter is required";
			public const string InValidToken = "Invalid token";
			public const string ExpectationFailed = "Unexpected error occurred while processing the data,Please check your inputs";

			public const string BadRequest = "The request was invalid or cannot be served. The exact error should be explained in the error payload as above.";
			public const string Unauthorised = "The request requires an user authentication.";
			public const string Forbidden = "The server understood the request, but is refusing it or the access is not allowed.";
			public const string Notfound = "There is no resource behind the URL.";
			public const string ServiceUnavailable = "Service unavailable.";

			public const string NoBarcode = "Barcode not found, Please use current barcode";
			public const string StudentNotYetRegister = "Student not yet register for current term";
			public const string NotYetRegisterForMealsCount = "You are either not registered or it is an invalid barcode. please contact your homeroom teacher.";
			public const string GoToMealsCountPage = "Meals count is not taken for today, Do you wish to take meals count now?";
		}
	}
}