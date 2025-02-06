using ClassLibrary.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Core.repository
{
    public interface ICourseRepo
    {
        List<Course> GetAllCourses();

        void createCourse(Course course);

        void updateCourse(Course course);

        void deleteCourse(int id);

        Course getCourseById(int id);
    }
}
