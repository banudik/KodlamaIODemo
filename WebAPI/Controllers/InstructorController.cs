using Business.Abstracts;
using Business.Dtos.Requests.Instructor;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class InstructorController : BaseController
{
    private readonly IInstructorService _instructorService;

    public InstructorController(IInstructorService instructorService)
    {
        _instructorService = instructorService;
    }

    [HttpPost("AddAsync")]
    public async Task<IActionResult> AddAsync(CreateInstructorRequest request)
    {
        return Ok(await _instructorService.AddAsync(request));
    }
    [HttpDelete("DeleteAsync")]
    public async Task<IActionResult> DeleteAsync(DeleteInstructorRequest request)
    {
        return Ok(await _instructorService.DeleteAsync(request));
    }

    [HttpPut("UpdateAsync")]
    public async Task<IActionResult> UpdateAsync(UpdateInstructorRequest request)
    {
        return Ok(await _instructorService.UpdateAsync(request));
    }

    [HttpGet("GetAllAsync")]
    public async Task<IActionResult> GetAllAsync()
    {
        return Ok(await _instructorService.GetAllAsync());
    }
}
