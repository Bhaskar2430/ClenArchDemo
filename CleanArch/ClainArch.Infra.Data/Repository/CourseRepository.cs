using ClainArch.Infra.Data.Context;
using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClainArch.Infra.Data.Repository
{

    public class CourseRepository : ICourseRepository
    {
        private UniversityDbContext _context;

        public CourseRepository(UniversityDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Course> GetCourse()
        {
            return _context.Courses;
        }
    }
}
