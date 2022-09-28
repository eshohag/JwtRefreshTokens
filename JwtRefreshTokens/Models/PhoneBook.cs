namespace JwtRefreshTokens.Models
{
    public class PhoneBook
    {
        public PhoneBook()
        {
            CreatedDate=DateTime.Now;
        }
        public int Id { get; set; }
        public string MobileNo { get; set; }
        public string FullName { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
