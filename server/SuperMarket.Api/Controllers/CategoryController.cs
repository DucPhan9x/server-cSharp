using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SuperMarket.Core.Models;
using SuperMarket.Services;
using System;

namespace SuperMarket.Api.Controllers
{
    [Route("api/[controller]")]
    public class CategoryController:ControllerBase
    {
        private readonly ICategoryServices _categoryServices;
        public CategoryController(ICategoryServices categoryServices){
            _categoryServices = categoryServices;
        }
        [HttpGet]
        public List<Category> Get(){
            return _categoryServices.GetCategories();
        }
        [HttpGet("{categoryId}")]
        public Category Get(int categoryId){
            return _categoryServices.GetCategory(categoryId);
        }

        [HttpPost]
        public Category Post(Category category){
            return _categoryServices.AddCategory(category);
        }
        [HttpPut("{categoryId}")]
        public Category Put(int categoryId,Category category){
            return _categoryServices.EditCategory(categoryId,category);
        }
        // [HttpDelete("categoryId")]
        // public Category Delete(int categoryId){
        //     _categoryServices.DeleteCategory(categoryId);
        // }
    }
}