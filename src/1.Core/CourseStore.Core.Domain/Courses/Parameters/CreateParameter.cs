using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseStore.Core.Domain.Courses.Parameters;

public sealed record CreateParameter(string Title,  string Description, string ImageUrl,long Price);