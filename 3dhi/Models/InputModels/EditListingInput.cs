using _3dhi.Enum;

namespace _3dhi.Models.InputModels
{
    public class EditListingInput
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string MainPhoto { get; set; }
    }
}
