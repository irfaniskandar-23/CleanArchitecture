﻿using CleanArch.Infra.Data.Context;
using ClearnArch.Domain.Interfaces;
using ClearnArch.Domain.Models;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {

        private UniversityDBContext _context;

        public CourseRepository(UniversityDBContext context)
        {
            _context = context;
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public IEnumerable<Course> GetCourses()
        {
            return _context.Courses;
        }
    }
}
