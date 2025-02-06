using ClassLibrary.Core.Data;
using ClassLibrary.Core.repository;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Infra.repository
{
    public class CourseRepo : ICourseRepo
    {
        LmsdemoDbContext dbContext;
        public CourseRepo(LmsdemoDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public void createCourse(Course course)
        {
            var parametre = new[]
            {
                new SqlParameter("@CourseId",course.Courseid),
                new SqlParameter("@Name",course.Coursename),
                new SqlParameter("@CategoryId", course.Categoryid),
                new SqlParameter("@Imagename",course.Imagename)
            };
            dbContext.Database.ExecuteSqlRaw("EXEC GETALLCOURSE @CourseId,@Name,@CategoryId,@Imagename", parametre);
        }

        public void deleteCourse(int id)
        {
            var parametrs = new SqlParameter("id", id);

            dbContext.Database.ExecuteSqlRaw("EXEC DeleteCourse @Id", parametrs);

        }

        public List<Course> GetAllCourses()
        {
            return dbContext.Courses.FromSqlRaw("EXEC GETALLCOURSE").ToList();
        }

        public Course getCourseById(int id)
        {
            var parametrss = new SqlParameter("id", id);

            return dbContext.Courses.FromSqlRaw("EXEC GetCourseNameById @Id", parametrss)
                .AsEnumerable().FirstOrDefault();
        }

        public void updateCourse(Course course)
        {
            var parametrees = new[]
{
                new SqlParameter("@CourseId",course.Courseid),
                new SqlParameter("@Name",course.Coursename),
                new SqlParameter("@CategoryId", course.Categoryid),
                new SqlParameter("@Imagename",course.Imagename)
            };
            dbContext.Database.ExecuteSqlRaw("EXEC UpdateCourse @CourseId,@Name,@CategoryId,@Imagename", parametrees);
        }
    }
}

