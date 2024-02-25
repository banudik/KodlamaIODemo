using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Category;
using Business.Dtos.Responses.Category;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes;

public class CategoryManager : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;
    private readonly IMapper _mapper;

    public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
    {
        _categoryRepository = categoryRepository;
        _mapper = mapper;
    }

    public async Task<IDataResult<CreatedCategoryResponse>> AddAsync(CreateCategoryRequest request)
    {
        Category category = _mapper.Map<Category>(request);
        await _categoryRepository.AddAsync(category);

        CreatedCategoryResponse response = _mapper.Map<CreatedCategoryResponse>(category);
        return new SuccessDataResult<CreatedCategoryResponse>(response, "Added Successfully");
    }

    public async Task<IDataResult<DeletedCategoryResponse>> DeleteAsync(DeleteCategoryRequest request)
    {
        Category category = _mapper.Map<Category>(request);
        await _categoryRepository.DeleteAsync(category);

        DeletedCategoryResponse response = _mapper.Map<DeletedCategoryResponse>(category);
        return new SuccessDataResult<DeletedCategoryResponse>(response, "Deleted Successfully");
    }

    public async Task<IDataResult<List<GetAllCategoryResponse>>> GetAllAsync()
    {
        var list = await _categoryRepository.GetAllAsync();
        List<GetAllCategoryResponse> response = _mapper.Map<List<GetAllCategoryResponse>>(list);

        return new SuccessDataResult<List<GetAllCategoryResponse>>(response, "Listed Successfully");
    }

    public async Task<IDataResult<UpdatedCategoryResponse>> UpdateAsync(UpdateCategoryRequest request)
    {
        Category category = _mapper.Map<Category>(request);
        await _categoryRepository.UpdateAsync(category);

        UpdatedCategoryResponse response = _mapper.Map<UpdatedCategoryResponse>(category);
        return new SuccessDataResult<UpdatedCategoryResponse>(response, "Updated successfully");
    }
}
