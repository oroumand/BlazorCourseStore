namespace CourseStore.Core.Domain.Courses.Parameters;

public sealed record CreateParameter(string Title,  string Description, string ImageUrl,long Price,int TeacherId);



