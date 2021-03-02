using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Entities.Concrete.Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult();
        }

        public IResult Delete(Entities.Concrete.Color color)
        {
            _colorDal.Delete(color);
            return new SuccessResult();
        }

        public IDataResult<List<Entities.Concrete.Color>> GetAll()
        {
            return new SuccessDataResult<List<Entities.Concrete.Color>>(_colorDal.GetAll());
        }

        public IDataResult<Entities.Concrete.Color> GetById(int colorId)
        {
            return new SuccessDataResult<Entities.Concrete.Color>(_colorDal.Get(c=> c.ColorId == colorId));
        }

        public IResult Update(Entities.Concrete.Color color)
        {
            _colorDal.Update(color);
            return new ErrorResult();
        }
    }
}
