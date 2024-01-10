﻿using CourseStore.Infra.Data.Sql.Queries.Common.Entities;

namespace CourseStore.Infra.Data.Sql.Queries.Teachers.Entities;
public class Teacher : QueryObject<int>
{
    #region Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Description { get; set; }
    public string ImageUrl { get; set; }
    #endregion


}

