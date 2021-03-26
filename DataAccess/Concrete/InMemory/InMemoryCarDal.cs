using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car{Id=1, BrandId=1, Description="Toyota Corolla "+" Sedan "+" Benzin "+" 10.374 Km "+" Manuel "+" Siyah", DailyPrice=170, ModelYear=2015},
            new Car{Id=2, BrandId=2, Description="Renault Clio Symbol "+" Sedan "+" Dizel "+" 12.384 Km "+" Manuel "+" Siyah", DailyPrice=149, ModelYear=2015},
            new Car{Id=3, BrandId=3, Description="Ford Focus "+" Orta Sınıf "+" Dizel "+" 0 Km "+" Otomatik "+" Beyaz", DailyPrice=99, ModelYear=2015},
            new Car{Id=4, BrandId=3, Description="Ford Mondeo "+" Orta Sınıf "+" Dizel "+" 0 Km "+" Otomatik "+" Bal Köpüğü", DailyPrice=119, ModelYear=2015},
            new Car{Id=5, BrandId=4, Description="Mercedes Vito "+" Minibüs "+" Dizel "+" 12.374 Km "+" Manuel "+" Siyah", DailyPrice=170, ModelYear=2015},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=>c.Id == car.Id);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAllByModel(int modelId)
        {
            throw new NotImplementedException();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            
        }
    }
}
