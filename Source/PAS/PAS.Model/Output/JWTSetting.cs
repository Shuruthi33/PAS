namespace PMT.Models
{
    public class JWTSetting
    {
        public string SecurityKey { get; set; } = string.Empty;
        public string AllowOrigin { get; set; } = string.Empty;
    }
}