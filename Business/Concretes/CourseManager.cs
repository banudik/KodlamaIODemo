using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Course;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.Course;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.Repositories;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes;

public class CourseManager : ICourseService
{
    private readonly ICourseRepository _courseRepository;
    private readonly IMapper _mapper;

    public CourseManager(ICourseRepository courseRepository, IMapper mapper)
    {
        _courseRepository = courseRepository;
        _mapper = mapper;
    }

    public async Task<IDataResult<CreatedCourseResponse>> AddAsync(CreateCourseRequest request)
    {
        Course course = _mapper.Map<Course>(request);
        await _courseRepository.AddAsync(course);

        CreatedCourseResponse response = _mapper.Map<CreatedCourseResponse>(course);
        return new SuccessDataResult<CreatedCourseResponse>(response, "Added Successfully");
    }

    public async Task<IDataResult<DeletedCourseResponse>> DeleteAsync(DeleteCourseRequest request)
    {
        Course course = _mapper.Map<Course>(request);
        await _courseRepository.DeleteAsync(course);

        DeletedCourseResponse response = _mapper.Map<DeletedCourseResponse>(course);
        return new SuccessDataResult<DeletedCourseResponse>(response, "Deleted Successfully");
    }

    public async Task<IDataResult<List<GetAllCourseResponse>>> GetAllAsync()
    {
        var list = await _courseRepository.GetAllAsync();
        List<GetAllCourseResponse> response = _mapper.Map<List<GetAllCourseResponse>>(list);

        return new SuccessDataResult<List<GetAllCourseResponse>>(response, "Listed Successfully");
    }

    public async Task<IDataResult<UpdatedCourseResponse>> UpdateAsync(UpdateCourseRequest request)
    {
        Course course = _mapper.Map<Course>(request);
        await _courseRepository.UpdateAsync(course);

        UpdatedCourseResponse response = _mapper.Map<UpdatedCourseResponse>(course);
        return new SuccessDataResult<UpdatedCourseResponse>(response, "Updated successfully");
    }
}
