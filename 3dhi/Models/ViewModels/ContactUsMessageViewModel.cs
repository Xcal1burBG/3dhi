namespace _3dhi.Models.ViewModels
{
    public class ContactUsMessageViewModel  
    {
        public string SenderName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Message { get; set; }

#nullable enable
        public string? PhoneNumber { get; set; }
        public bool IsMessageRead { get; set; }
    }
}
