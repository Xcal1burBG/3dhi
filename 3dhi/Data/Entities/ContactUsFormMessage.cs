namespace _3dhi.Data.Entities
{
    public class ContactUsFormMessage
    {
        public string SenderName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Message { get; set; }
        public bool IsMessageRead { get; set; }

#nullable enable
        public string? PhoneNumber { get; set; }
    }
}
