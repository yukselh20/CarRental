using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService 
    {

        IDataResult<List<Car>> GetAll();
        IDataResult<Car> GetById(int id);
        IDataResult<List<Car>> GetAllByModelYear(int min, int max);
        IDataResult<List<Car>> GetByDailyPrice(short min, short max);
        IDataResult<List<Car>> GetCarsByBrandId(int id);
        IDataResult<List<Car>> GetCarsByColorId(int id);
        IDataResult<List<CarDetailDto>> GetCarDetails();
        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
        //List<Car> GetAll();
        //List<Car> GetCarsById(int id);
        //List<Car> GetCarsByBrandId(int brandId);
        //List<Car> GetCarsByColorId(int colorId);

        //void Add(Car car);
    }
}
