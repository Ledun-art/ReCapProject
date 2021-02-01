using Entities.Abstract;

namespace Entities.Concrete
{
    public class RentCars : IEntity
    {
        public string CarName { get; set; }
        public bool VehicleElectric { get; set; }
    }
}