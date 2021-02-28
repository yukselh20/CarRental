using Business.Abstract;
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

        public void Add(Entities.Concrete.Color color)
        {
            _colorDal.Add(color);
        }

        public void Delete(Entities.Concrete.Color color)
        {
            _colorDal.Delete(color);
        }

        public List<Entities.Concrete.Color> GetAll()
        {
            return _colorDal.GetAll();
        }

        public Entities.Concrete.Color GetById(int colorId)
        {
            return _colorDal.Get(c=> c.ColorId == colorId);
        }

        public void Update(Entities.Concrete.Color color)
        {
            _colorDal.Update(color);
        }
    }
}
