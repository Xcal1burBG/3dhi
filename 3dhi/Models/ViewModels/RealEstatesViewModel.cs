using _3dhi.Data.Entities;

namespace _3dhi.Models.ViewModels
{
    public class RealEstatesViewModel
    {
        public string Location { get; set; }
        public string Description { get; set; }
        public Decimal Price { get; set; }
        public ICollection<PhotoPath> Photos { get; set; }

    }
}
