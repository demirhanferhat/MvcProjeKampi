using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactServices
    {

        List<Contact> GetList();
        void ContactAdd(Contact contact);

        Contact GetByID(int id);

        //Contact id göre silme işlemi
        void ContactDelete(Contact contact);

        //Contact id göre güncelleme işlemi
        void ContactUpdate(Contact contact);
    }
}
