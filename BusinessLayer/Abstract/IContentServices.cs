using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentServices
    {
        List<Content> GetList();
        List<Content> GetListByHeadingID(int id); 
        void ContentAdd(Content content);
        Content GetByID(int id);

        //Category id göre silme işlemi
        void ContentDelete(Content content);

        //Category id göre güncelleme işlemi
        void ContentUpdate(Content content);
    }
}
