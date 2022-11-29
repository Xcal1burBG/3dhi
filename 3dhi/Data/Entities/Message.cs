using System.Diagnostics.CodeAnalysis;

namespace _3dhi.Data.Entities
{
    public class Message
    {
        public Guid Id { get; set; }
        public DateTime Date { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Text { get; set; }
        public bool IsMessageRead { get; set; }
    }
}
