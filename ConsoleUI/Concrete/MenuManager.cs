using System;
using Business.Concrete;
using ConsoleUI.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace ConsoleUI.Concrete
{
    public class MenuManager : IMenuService
    {
        public void Menu()
        {
            MenuShow();
            string input = Console.ReadLine();
            CarManager carManager = new CarManager(new InMemoryCarDal());


            switch (input)
            {
                case "1":

                    foreach (var category in carManager.GetAllCategories())
                    {
                        Console.WriteLine(category.CategoryId + " " + category.CategoryName);
                    }

                    break;
                case "2":
                    foreach (var cars in carManager.GetAll())
                    {
                        Console.WriteLine(cars.Id + " " + cars.BrandId + " " + cars.ColorId + " " + cars.Modelyear +
                                          " " + cars.DailyPrice + " " + cars.Description);
                    }

                    break;
                case "3":
                    foreach (var rented in carManager.RentCarsList())
                    {
                        Console.WriteLine(rented.CarName + " " + "Is the vehicle electric ?" + " " +
                                          rented.VehicleElectric);
                    }

                    break;
                case "4":
                    var carId = CarAddList(out var carBrandId, out var carColorId, out var carModelYear,
                        out var carDailyPrice, out var carDescription);

                    carManager.Add(new Car
                    {
                        Id = carId, BrandId = carBrandId, ColorId = carColorId, Modelyear = carModelYear,
                        DailyPrice = carDailyPrice, Description = carDescription
                    });


                    foreach (var cars in carManager.GetAll())
                    {
                        Console.WriteLine(cars.Id + " " + cars.BrandId + " " + cars.ColorId + " " + cars.Modelyear +
                                          " " + cars.DailyPrice + " " + cars.Description);
                    }

                    Console.WriteLine("The vehicle has been added and the list has been updated !");

                    break;
            }
        }

        private static void MenuShow()
        {
            Console.WriteLine("1.Bring categories !");
            Console.WriteLine("2.List All Products !");
            Console.WriteLine("3. List electric vehicles !");
            Console.WriteLine("4. Add new vehicle!");
        }

        private static int CarAddList(out int carBrandId, out int carColorId, out string carModelYear,
            out int carDailyPrice,
            out string carDescription)
        {
            Console.WriteLine("Enter vehicle Id: ");
            int carId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Brand Id : ");
            carBrandId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter vehicle color Id : ");
            carColorId = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the vehicle model year");
            carModelYear = Console.ReadLine();
            Console.WriteLine("Enter the daily price of the vehicle");
            carDailyPrice = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the vehicle description");
            carDescription = Console.ReadLine();
            return carId;
        }
    }
}