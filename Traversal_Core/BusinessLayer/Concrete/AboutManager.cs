using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAboutDal _abaoutDal;

        public AboutManager(IAboutDal abaoutDal)
        {
            _abaoutDal = abaoutDal;
        }

        public void TAdd(About t)
        {
            _abaoutDal.Insert(t);
        }

        public void TDelete(About t)
        {
           _abaoutDal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<About> TGetList()
        {
           return _abaoutDal.GetList();
        }

        public void TUpdate(About t)
        {
            _abaoutDal.Update(t);
        }
    }
}
