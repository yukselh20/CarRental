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
    //IBrandDal ın durma sebebi DTO joinleme vs olursa bu kısmı ilgilendiren fonksiyonları
    //IBrandDal kısmına yazıp buraya iplemente edebiliriz.
    public class EfBrandDal : EfEntityRepositoryBase<Brand, RentCarContext>, IBrandDal
    {
       
    }
}
