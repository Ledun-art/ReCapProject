using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Category> GetAllCategories();

        List<RentCars> RentCarsList();
    }
}