using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new ErrorResult(Messages.ProductNameInvalid);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll(),Messages.ProductsListed);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            return new ErrorDataResult<Brand>(_brandDal.Get(b => b.BrandId == brandId),Messages.ProductsNotListed);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new ErrorResult(Messages.ProductNotUpdated);
        }
    }
}
