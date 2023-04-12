using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> GetList();
        void headingAdd(Heading heading);

        Heading GetByID(int id);

        //Heading id göre silme işlemi
        void HeadingDelete(Heading heading);

        //Heading id göre güncelleme işlemi
        void HeadingUpdate(Heading heading);
    }
}
