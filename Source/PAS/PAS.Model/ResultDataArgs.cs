using PAS.Model.Input;

namespace PAS.Model
{
    public class ResultDataArgs
    {
        public Int64 StatusCode { get; set; }
        public string? StatusMessage { get; set; }
        public string? MessageTitle { get; set; }
        public object? ResultData { get; set; }

    }

   
}