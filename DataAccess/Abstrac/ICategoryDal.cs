﻿using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstrac
{
    public interface ICategoryDal : IEntityRepository<Category>
    {
    }
}
