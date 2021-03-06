using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{

    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;

        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car{Id=1, BrandId=1,ColorId=3, ModelYear=2014, DailyPrice=150, Description ="1.6 motor"},
                new Car{Id=2, BrandId=2,ColorId=4, ModelYear=2013, DailyPrice=120, Description ="1.3 motor"},
                new Car{Id=3, BrandId=3,ColorId=1, ModelYear=2015, DailyPrice=160, Description ="1.2 motor"},
                new Car{Id=4, BrandId=4,ColorId=2, ModelYear=2018, DailyPrice=180, Description ="2.0 motor"},
            };
        }   


        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteToCar = _car.SingleOrDefault(p => p.Id == car.Id);
            _car.Remove(deleteToCar);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetById(int id)
        {
            return _car.Where(p => p.Id == id).ToList();

        }

        public void Update(Car car)
        {
            Car updateToCar = _car.SingleOrDefault(p => p.Id == car.Id);
            updateToCar.Id = car.Id;
            updateToCar.ColorId = car.ColorId;
            updateToCar.BrandId = car.BrandId;
            updateToCar.DailyPrice = car.DailyPrice;
            updateToCar.Description = car.Description;
        }
    }
}

        

            
            

                
     

