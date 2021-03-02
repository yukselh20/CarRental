using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //iplementeler den önce burada interfacedeki fonksiyonları detaylandırıyorduk.
    //IColorDal ın durma sebebi DTO joinleme vs olursa bu kısmı ilgilendiren fonksiyonları
    //IColorDal kısmına yazıp buraya iplemente edebiliriz.
    public class EfColorDal : EfEntityRepositoryBase<Color, RentCarContext>, IColorDal
    {
      
    }
}
