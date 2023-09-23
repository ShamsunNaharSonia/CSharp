using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetails
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAllCar();
        Car GetCarByID(int id);
        Car InsertNewCar(Car car);
      Car UpdateCar(Car car);
       Car DeleteCar(int id);

    }
}
