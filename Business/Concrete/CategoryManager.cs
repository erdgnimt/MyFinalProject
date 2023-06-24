﻿using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
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

        public IResult Add(Category category)
        {
            if (DateTime.Now.Hour == 22)
            {
                _categoryDal.Add(category);
                return new SuccessResult(Messages.CategoryAdded);
            }
            else
            {
                return new ErrorResult(Messages.MaintenanceTime);
            }
        }

        public IDataResult<List<Category>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(),Messages.CategoryListed);
            }
            else
            {
                return new ErrorDataResult<List<Category>>(Messages.MaintenanceTime);
            }
            
        }

        public IDataResult<Category> GetById(int id)
        {
            if (DateTime.Now.Hour == 14)
            {
                return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == id), Messages.CategoryListed);
            }
            else
            {
                return new ErrorDataResult<Category>(Messages.MaintenanceTime);
            }          
        }
    }
}
