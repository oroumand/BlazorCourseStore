﻿namespace CourseStore.Core.RequestResponse.Courses.Queries.GetDetail
{
    public class GetCourseDetailQr
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public long Price { get; set; }
        public string Image { get; set; }
    }
}
