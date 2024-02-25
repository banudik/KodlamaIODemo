using Business.Abstracts;
using Business.Dtos.Requests.Course;
using Business.Dtos.Requests.Instructor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CourseController : BaseController
{
    private readonly ICourseService _courseService;

    public CourseController(ICourseService courseService)
    {
        _courseService = courseService;
    }

    [HttpPost("AddAsync")]
    public async Task<IActionResult> AddAsync(CreateCourseRequest request)
    {
        return Ok(await _courseService.AddAsync(request));
    }
    [HttpDelete("DeleteAsync")]
    public async Task<IActionResult> DeleteAsync(DeleteCourseRequest request)
    {
        return Ok(await _courseService.DeleteAsync(request));
    }

    [HttpPut("UpdateAsync")]
    public async Task<IActionResult> UpdateAsync(UpdateCourseRequest request)
    {
        return Ok(await _courseService.UpdateAsync(request));
    }

    [HttpGet("GetAllAsync")]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _courseService.GetAllAsync());
    }
}
