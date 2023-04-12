using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IMessageServices
    {
        List<Message> GetListInbox();
        List<Message> GetListSendbox();
        void MessageAdd(Message message);

        Message GetByID(int id);

        //Message id göre silme işlemi
        void MessageDelete(Message message);

        //Category id göre güncelleme işlemi
        void MessageUpdate(Message message);
    }
}
