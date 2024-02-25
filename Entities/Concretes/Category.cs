﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Category:BaseEntity<Guid>
{
    public string Name { get; set; }
    public ICollection<Course> Courses { get; set; }
}
