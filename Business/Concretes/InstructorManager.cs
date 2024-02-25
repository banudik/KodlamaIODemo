using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses.Course;
using Business.Dtos.Responses.Instructor;
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

public class InstructorManager : IInstructorService
{
    private readonly IInstructorRepository _instructorRepository;
    private readonly IMapper _mapper;

    public InstructorManager(IInstructorRepository instructorRepository, IMapper mapper)
    {
        _instructorRepository = instructorRepository;
        _mapper = mapper;
    }

    public async Task<IDataResult<CreatedInstructorResponse>> AddAsync(CreateInstructorRequest request)
    {
        Instructor instructor = _mapper.Map<Instructor>(request);
        await _instructorRepository.AddAsync(instructor);

        CreatedInstructorResponse response = _mapper.Map<CreatedInstructorResponse>(instructor);
        return new SuccessDataResult<CreatedInstructorResponse>(response, "Added Successfully");
    }

    public async Task<IDataResult<DeletedInstructorResponse>> DeleteAsync(DeleteInstructorRequest request)
    {
        Instructor instructor = _mapper.Map<Instructor>(request);
        await _instructorRepository.DeleteAsync(instructor);

        DeletedInstructorResponse response = _mapper.Map<DeletedInstructorResponse>(instructor);
        return new SuccessDataResult<DeletedInstructorResponse>(response, "Deleted Successfully");
    }

    public async Task<IDataResult<List<GetAllInstructorResponse>>> GetAllAsync()
    {
        var list = await _instructorRepository.GetAllAsync();
        List<GetAllInstructorResponse> response = _mapper.Map<List<GetAllInstructorResponse>>(list);

        return new SuccessDataResult<List<GetAllInstructorResponse>>(response, "Listed Successfully");
    }

    public async Task<IDataResult<UpdatedInstructorResponse>> UpdateAsync(UpdateInstructorRequest request)
    {
        Instructor instructor = _mapper.Map<Instructor>(request);
        await _instructorRepository.UpdateAsync(instructor);

        UpdatedInstructorResponse response = _mapper.Map<UpdatedInstructorResponse>(instructor);
        return new SuccessDataResult<UpdatedInstructorResponse>(response, "Updated successfully");
    }
}
