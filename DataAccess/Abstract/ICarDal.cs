using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface ICarDal
    {
        List<Car> GetAll();
        List<Category> GetAllByCategory();
        List<RentCars> GetAllByRentedCar();
        void GetById(Car car);
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
    }
}