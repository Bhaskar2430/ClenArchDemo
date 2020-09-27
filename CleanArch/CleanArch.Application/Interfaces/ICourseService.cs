using CleanArch.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Application.Interfaces
{
    interface ICourseService
    {
        public IEnumerable<CourseViewModel> GetCourses();
    }
}
