using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Instructor;
using Core.Utilities.Results;

namespace Business.Abstracts;

public interface IInstructorService
{
    Task<IDataResult<CreatedInstructorResponse>> AddAsync(CreateInstructorRequest request);
    Task<IDataResult<DeletedInstructorResponse>> DeleteAsync(DeleteInstructorRequest request);
    Task<IDataResult<UpdatedInstructorResponse>> UpdateAsync(UpdateInstructorRequest request);
    Task<IDataResult<List<GetAllInstructorResponse>>> GetAllAsync();
}
