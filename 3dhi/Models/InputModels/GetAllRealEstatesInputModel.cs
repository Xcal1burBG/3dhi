using _3dhi.Data.Entities;

namespace _3dhi.Models.InputModels
{
    public class GetAllRealEstatesInputModel
    {
        public ICollection<RealEstate> RealEstates { get; set; }
    }
}
