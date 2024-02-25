using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete;

public class Category : BaseEntity<int>
{
    public string Name { get; set; }
    public ICollection<Course> Courses { get; set; }
}
