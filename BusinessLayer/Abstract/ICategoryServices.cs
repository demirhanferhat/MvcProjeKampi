using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryServices
    {
        List<Category> GetList();
        void CategoryAdd(Category category);

        Category GetByID(int id);

        //Category id göre silme işlemi
        void CategoryDelete(Category category);

        //Category id göre güncelleme işlemi
        void CategoryUpdate(Category category);

    }
}
