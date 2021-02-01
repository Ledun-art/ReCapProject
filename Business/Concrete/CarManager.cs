using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        private ICarDal _carDal;
        private ICarDal _carService;
        private ICarDal _rentedService;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
            _carService = carDal;
            _rentedService = carDal;
        }

        //List All Cars
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }
        //List All Categories

        public List<Category> GetAllCategories()
        {
            return _carService.GetAllByCategory();
        }

        //List Rented Car List
        public List<RentCars> RentCarsList()
        {
            return _rentedService.GetAllByRentedCar();
        }


        public void Add(Car car)
        {
            _carDal.Add(car);
        }
    }
}