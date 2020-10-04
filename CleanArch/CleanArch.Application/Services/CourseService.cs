using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Models;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository CourseRepository)
        {
            _courseRepository = CourseRepository;
        }
        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourse()
            };
        }
    }

    public class OffersService : IOffersService
    {
        private IOffersRepository _offersRepository;

        public OffersService(IOffersRepository offersRepository)
        {
            _offersRepository = offersRepository;
        }
        public OffersViewModel GetOffers()
        {
            return new OffersViewModel()
            {
                Offers = _offersRepository.GetOffers()
            };
        }
    }
}
