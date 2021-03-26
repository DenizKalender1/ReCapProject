using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, ReCarContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (ReCarContext context = new ReCarContext())
            {
                var result = from p in context.Cars
                             join c in context.Brands
                             on p.Id equals c.BrandId
                             select new CarDetailDto
                             {
                                 CarName = p.CarName,
                                 BrandName = c.BrandName,
                                 ColorName = p.ColorName,
                                 DailyPrice = p.DailyPrice
                             };
                return result.ToList();
            }
        }
    }
}
