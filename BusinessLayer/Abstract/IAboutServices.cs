using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IAboutServices
    {
        List<About> GetList();
        void AboutAdd(About about);

        About GetByID(int id);

        //About id göre silme işlemi
        void AboutDelete(About about);

        //About id göre güncelleme işlemi
        void AboutUpdate(About about);
    }
}
