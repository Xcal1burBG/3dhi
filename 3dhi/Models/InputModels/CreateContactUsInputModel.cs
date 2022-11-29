namespace _3dhi.Models.InputModels
{
    public class CreateContactUsInputModel
    {
        public string SenderName { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }

        public bool IsMessageRead { get; set; }
#nullable enable
        public string? PhoneNumber { get; set; }
    }
}
