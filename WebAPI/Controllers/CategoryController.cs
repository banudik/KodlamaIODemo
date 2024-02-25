using Business.Abstracts;
using Business.Dtos.Requests.Category;
using Business.Dtos.Requests.Course;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : BaseController
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }

    [HttpPost("AddAsync")]
    public async Task<IActionResult> AddAsync(CreateCategoryRequest request)
    {
        return Ok(await _categoryService.AddAsync(request));
    }
    [HttpDelete("DeleteAsync")]
    public async Task<IActionResult> DeleteAsync(DeleteCategoryRequest request)
    {
        return Ok(await _categoryService.DeleteAsync(request));
    }

    [HttpPut("UpdateAsync")]
    public async Task<IActionResult> UpdateAsync(UpdateCategoryRequest request)
    {
        return Ok(await _categoryService.UpdateAsync(request));
    }

    [HttpGet("GetAllAsync")]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _categoryService.GetAllAsync());
    }
}
