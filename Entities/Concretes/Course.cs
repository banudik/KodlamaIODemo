using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Course:BaseEntity<Guid>
{
    public string Name { get; set; }
    public Guid CategoryId { get; set; }
    public Guid InstructorId { get; set; }
    public string ImageUrl { get; set; }
    public string Price { get; set; }
    public Category Category { get; set; }
    public Instructor Instructor { get; set; }
}
