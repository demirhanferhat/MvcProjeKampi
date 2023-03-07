using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repositories;
using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _categorydal;

        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        //Category eklemek için
        public void CategoryAdd(Category category)
        {
            _categorydal.Insert(category);
        }

        //Category'den gelen değeri sil
        public void CategoryDelete(Category category)
        {
            _categorydal.Delete(category);
        }
        //Category'den gelen değeri güncelle
        public void CategoryUpdate(Category category)
        {
            _categorydal.Update(category);
        }

        //Category'de id bulmak için kullan
        public Category GetByID(int id)
        {
            return _categorydal.Get(x=>x.CategoryID == id);
        }

        //Category listelemek için
        public List<Category> GetList()
        {
           return _categorydal.List();
        }

    }
}
