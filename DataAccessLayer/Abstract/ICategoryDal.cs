﻿using EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface ICategoryDal
    {
        //CRUD için paremetreleri tanımladık
        List<Category> List();

        void Insert(Category p);
        
        void Update(Category p);

        void Delete(Category p);


    }
}
