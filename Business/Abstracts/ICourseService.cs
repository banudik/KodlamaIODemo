using Business.Dtos.Requests.Category;
using Business.Dtos.Requests.Course;
using Business.Dtos.Responses.Category;
using Business.Dtos.Responses.Course;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ICourseService
{
    Task<IDataResult<CreatedCourseResponse>> AddAsync(CreateCourseRequest request);
    Task<IDataResult<DeletedCourseResponse>> DeleteAsync(DeleteCourseRequest request);
    Task<IDataResult<UpdatedCourseResponse>> UpdateAsync(UpdateCourseRequest request);
    Task<IDataResult<List<GetAllCourseResponse>>> GetAllAsync();
}
