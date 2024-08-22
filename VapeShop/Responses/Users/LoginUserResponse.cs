namespace VapeShop.Web.Responses.Users
{
    public class LoginUserResponse
    {
        public string Phone { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public long Id { get; set; }
    }
}
