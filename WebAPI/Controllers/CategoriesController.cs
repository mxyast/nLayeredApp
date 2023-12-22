﻿using Business.Abstracts;
using Business.Dtos.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] CreateCategoryRequest createCategoryRequest)
        {
            var result = await _categoryService.Add(createCategoryRequest);
            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var result = await _categoryService.GetListAsync();
            return Ok(result);
        }
    }
}
