﻿using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal category)
        {
            _categoryDal = category;
        }
        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
    }
}