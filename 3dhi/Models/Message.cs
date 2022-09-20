using System.Diagnostics.CodeAnalysis;

namespace _3dhi.Models
{
    public class Message
    {
        public DateTime Date { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Text { get; set; }
    }
}
