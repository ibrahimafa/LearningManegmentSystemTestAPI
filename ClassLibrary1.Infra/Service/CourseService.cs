using ClassLibrary.Core.Data;
using ClassLibrary.Core.repository;
using ClassLibrary1.Infra.repository;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Infra.Service
{
    public class CourseService: ICourseService
    {
        ICourseRepo courseRepo;
        public CourseService(ICourseRepo _courseRepo) 
        {
            courseRepo = _courseRepo;
        }
       public List<Course> GetAllCourses()
        {
            return courseRepo.GetAllCourses();
        }

        public  void createCourse(Course course)
        {
            courseRepo.createCourse(course);
        }

        public void updateCourse(Course course)
        {
            courseRepo.updateCourse(course);
        }

        public void deleteCourse(int id)
        {
            courseRepo.deleteCourse(id);
        }

        public Course getCourseById(int id)
        {
            return (courseRepo.getCourseById(id));
        }
    }
}
