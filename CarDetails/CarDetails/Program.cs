using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarDetails
{
    public class Program
    {
        static CarRepository repo = new CarRepository();
        static void Main(string[] args)
        {
            try
            {
               DataInitialize();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
            Console.ReadKey();
        }

        private static void DataInitialize()
        {
            string operation = "";
            Console.WriteLine("");
            Console.WriteLine("CSharp Project ON-\nRepository Pattern Application\nProject Name: CarDetails \nProject Made By \nShamsun Nahar \nTrainee ID: 1271720\nBatch ID: ESAD-CS/USSL-A/53/01");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("\t\t\t\tMy Application\r");
            Console.WriteLine("\t\t\t\t--------------\n");
            Console.WriteLine("How Many Operation Do You Want To Perform ?");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number > 0)
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine("\t\t\t\t--Search Option: (Select, Insert,Update,Delete).....\n");
                    operation = Console.ReadLine();
                    switch (operation)
                    {
                        case "Select":

                            ShowCarDetails(null);
                            break;
                        case "Insert":
                            InsertNewCar();
                            break;
                        case "Update":
                            UpdateCar();
                            break;
                        case "Delete":
                            DeleteCar();
                            break;
                        default:
                            break;
                    }

                }


            }
            else
            {
                System.Environment.Exit(0);
            }
        }

        private static void DeleteCar()
        {
           Car deleteCar = new Car();
            deleteCar.CarId = 103;
            repo.DeleteCar(deleteCar.CarId);
            Console.WriteLine("Car Item Deleted ");
            Console.WriteLine();
            ShowCarDetails(null);
        }

        private static void UpdateCar()
        {
            Car car = new Car();
            Console.WriteLine("Enter Car Id");
            int id=Convert.ToInt32(Console.ReadLine());
            car.CarId = id;
            Console.WriteLine("Enter Car Model ");
            string model = Console.ReadLine();
            car.CarModel = model;
            Console.WriteLine("Enter Brand Name \n Hints* \t0.None,\t1.Ford,\t2.Charry,\t3.Honda,\t4.Altis");
            string brand = (Console.ReadLine());
            CarBrand brandValue = (CarBrand)Enum.Parse(typeof(CarBrand), brand.ToString());
            car.BrandName = brandValue;
            Console.WriteLine("Enter Color Name \n Hints* \t1.Silver,\t2.Red,\t3.Blue,\t4.Black");
            string color = (Console.ReadLine());
            Color colorName = (Color)Enum.Parse(typeof(Color), color.ToString());
            car.CarColor = colorName;
            Console.WriteLine("Enter Car Price");
            double price = Convert.ToDouble(Console.ReadLine());
            car.CarPrice = price;

            repo.UpdateCar(car);
            Console.WriteLine("Car Item Updated");
            Console.WriteLine();
            ShowCarDetails(null);
        }

        private static void InsertNewCar()
        {
            Car car = new Car();
            
            Console.WriteLine("Enter Car Model ");
            string model = Console.ReadLine();
            car.CarModel = model;
            Console.WriteLine("Enter Brand Name \n Hints* \t0.None,\t1.Ford,\t2.Charry,\t3.Honda,\t4.Altis");
            string brand=(Console.ReadLine());
            CarBrand brandValue = (CarBrand)Enum.Parse(typeof(CarBrand), brand.ToString());
            car.BrandName = brandValue;
            Console.WriteLine("Enter Color Name \n Hints* \t1.Silver,\t2.Red,\t3.Blue,\t4.Black");
            string color = (Console.ReadLine());
            Color colorName = (Color)Enum.Parse(typeof(Color), color.ToString());
            car.CarColor= colorName;
            Console.WriteLine("Enter Car Price");
            double price = Convert.ToDouble(Console.ReadLine());
            car.CarPrice = price;
            
            repo.InsertNewCar(car);
            Console.WriteLine("Car Item Inserted");
            Console.WriteLine();
            ShowCarDetails(null);

        }

        private static void ShowCarDetails(Car car)
        {
            List<Car> list = new List<Car>();
            Console.WriteLine(string.Format("{0,10}|{1,10}|{2,-10}|{3,-10}|{4,-30}", "CarID", "CarModel", "BrandName", "CarColor","CarPrice"));
            Console.WriteLine();
            list = repo.GetAllCar().ToList();

            
            foreach (var item in list)
            {
                Console.WriteLine(string.Format("{0,10}|{1,10}|{2,-10}|{3,-10}|{4,-30}", item.CarId, item.CarModel, item.BrandName, item.CarColor,item.CarPrice));
               
            }
            Console.WriteLine();
        }

    }
}
