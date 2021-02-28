using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService 
    {

        List<Car> GetAll();
        Car GetById(int carId);
        List<Car> GetAllByModelYear(int min, int max);
        List<Car> GetByDailyPrice(short min, short max);
        List<Car> GetCarsByBrandId(int brandId);
        List<Car> GetCarsByColorId(int colorId);
        List<CarDetailDto> GetCarDetails();
        void Add(Car car);
        void Delete(Car car);
        void Update(Car car);
        //List<Car> GetAll();
        //List<Car> GetCarsById(int id);
        //List<Car> GetCarsByBrandId(int brandId);
        //List<Car> GetCarsByColorId(int colorId);

        //void Add(Car car);
    }
}
