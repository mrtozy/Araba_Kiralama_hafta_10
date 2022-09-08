
using Business.Concrete;
using Entities.Concrete;


using DataAccess.Concrete.EntityFramework;


namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            MusteriEkle();
            ArabaGetir();
            ArabaId();
        }

    
        private static void ArabaId()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(3).Data.DailyPrice);
        }

        public static void ArabaGetir()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("{0} - {1} - {2} - {3}", car.CarId, car.BrandName,car.ColorName, car.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }
        public static void MusteriEkle()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 10, CustomerId=10 ,CompanyName = "şirket1" });
            customerManager.Add(new Customer { UserId = 11, CustomerId = 11, CompanyName = "şirket2" });

            var result = customerManager.GetAll();
            foreach (var customer in result.Data)
            {

                Console.WriteLine("{0} - {1} - {2}", customer.CustomerId, customer.UserId, customer.CompanyName);
            }
        }














      

     

      
    }
}