using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts;

public interface ICategoryService
{
    Task<IDataResult<CreatedCategoryResponse>> AddAsync (CreateCategoryRequest request);
    Task<IDataResult<DeletedCategoryResponse>> DeleteAsync(DeleteCategoryRequest request);
    Task<IDataResult<UpdatedCategoryResponse>> UpdateAsync(UpdateCategoryRequest request);
    Task<IDataResult<List<GetAllCategoryResponse>>> GetAllAsync();
}
