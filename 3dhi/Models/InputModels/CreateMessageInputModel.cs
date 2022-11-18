namespace _3dhi.Models.InputModels
{
    public class CreateMessageInputModel
    {
        public DateTime Date { get; set; }
        public Guid SenderId { get; set; }
        public Guid ReceiverId { get; set; }
        public string Text { get; set; }
    }
}
