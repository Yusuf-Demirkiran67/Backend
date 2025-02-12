﻿using Core.DataAccess;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
        List<ProductDetail> GetProductDetails();
    }
}
