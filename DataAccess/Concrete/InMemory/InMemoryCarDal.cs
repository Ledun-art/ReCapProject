using System.Collections.Generic;
using System.Linq;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;
        private List<Category> _categories;
        private List<RentCars> _rentCars;


        public InMemoryCarDal()
        {
            //Simulation database
            _rentCars = new List<RentCars>
            {
                new RentCars
                {
                    CarName = "TESLA", VehicleElectric = true,
                },
                new RentCars
                {
                    CarName = "BMW", VehicleElectric = true,
                },
                new RentCars
                {
                    CarName = "AUDİ", VehicleElectric = false,
                }
            };


            _categories = new List<Category>
            {
                new Category
                {
                    CategoryId = 1, CategoryName = "Classic Cars"
                },
                new Category
                {
                    CategoryId = 2, CategoryName = "Super Sports"
                },
                new Category
                {
                    CategoryId = 3, CategoryName = "SUV"
                },
                new Category
                {
                    CategoryId = 4, CategoryName = "Sedans"
                }
            };

            _cars = new List<Car>
            {
                new Car
                {
                    Id = 1, BrandId = 1, ColorId = 1, Modelyear = "2010",
                    DailyPrice = 100, Description = "Old Car"
                },
                new Car
                {
                    Id = 2, BrandId = 2, ColorId = 2, Modelyear = "2011",
                    DailyPrice = 300, Description = "New Car"
                },
                new Car
                {
                    Id = 3, BrandId = 3, ColorId = 3, Modelyear = "2012",
                    DailyPrice = 50, Description = "Very Old Car"
                },
                new Car
                {
                    Id = 4, BrandId = 4, ColorId = 4, Modelyear = "2013",
                    DailyPrice = 600, Description = "Classic Car"
                },
                new Car
                {
                    Id = 5, BrandId = 5, ColorId = 5, Modelyear = "2014",
                    DailyPrice = 1000, Description = "Super sport Car"
                },
            };
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public void GetById(Car car)
        {
            Car carGetById = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Add(carGetById);
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Description = car.Description;
            carToUpdate.Modelyear = car.Modelyear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
        }

        public List<Category> GetAllByCategory()
        {
            return _categories;
        }

        public List<RentCars> GetAllByRentedCar()
        {
            return _rentCars;
        }
    }
}