using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetails
{
    public class CarRepository : ICarRepository
    {
        private List<Car> _carList;
        public CarRepository()
        {
            _carList = new List<Car>()
            {
                new Car(){CarId=101,CarModel="Fusion" ,BrandName=CarBrand.Ford,CarColor= Color.Red,CarPrice=5000000 },
               new Car(){CarId=102,CarModel="Impala" ,BrandName=CarBrand.Charry,CarColor= Color.Black,CarPrice=5400000 },
                new Car(){CarId=103,CarModel="Impala" ,BrandName=CarBrand.Honda,CarColor= Color.Silver,CarPrice=4000000 },
               new Car(){CarId=104,CarModel="Accor" ,BrandName=CarBrand.Ford,CarColor= Color.Blue,CarPrice=6000000  },
               new Car(){CarId=105,CarModel="Fusion" ,BrandName=CarBrand.Ford,CarColor= Color.Black ,CarPrice = 7000000},
            };
        }

        public Car DeleteCar(int id)
        {
            Car cars = GetCarByID(id);
            if (cars != null)
            {
                _carList.Remove(cars);
            }
            return cars;
        }

        public IEnumerable<Car> GetAllCar()
        {
            return _carList;
        }

        public Car GetCarByID(int id)
        {
            Car car = (from c in _carList where c.CarId == id select c).Single();
            return car as Car;
        }

        public Car InsertNewCar(Car insertcar)
        {
           Car cars = ((from c in _carList orderby c.CarId descending select c).Take(1))

               .Single() as Car; 
            insertcar.CarId = cars.CarId + 1;
            _carList.Add(insertcar);
            return insertcar;
        }

        public Car UpdateCar(Car updateCar)
        {
            Car cars= GetCarByID(updateCar.CarId);
            if (cars != null)
            {
                cars.CarModel = updateCar.CarModel;
                cars.BrandName = updateCar.BrandName;
                cars.CarColor = updateCar.CarColor;
                cars.CarPrice= updateCar.CarPrice;
            }
            return cars;
        }
    }
}
