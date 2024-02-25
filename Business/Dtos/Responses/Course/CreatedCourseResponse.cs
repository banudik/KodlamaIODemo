using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses.Course;

public class CreatedCourseResponse
{
    public string Name { get; set; }
    public int CategoryId { get; set; }
    public int InstructorId { get; set; }
    public string ImageUrl { get; set; }
    public string Price { get; set; }
}
