using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvcbasics.Models
{
    public class Repository
    {
        public static List<Course> Courses { get; set; } = new List<Course>()
        {
            
           
                new Course()
                {
                    Id = 1,
                    Title = "AspNet Core",
                    Description = "GG-1",
                    Image = "1.jpg"
                },
                 new Course()
                {
                    Id = 2,
                    Title = "React-JS",
                    Description = "GG-2",
                    Image = "2.jpg"
                },
                 new Course()
                {
                    Id = 3,
                    Title = "Redux Toolkit",
                    Description = "GG-3",
                    Image = "3.jpg"
                },
                 new Course()
                {
                    Id = 4,
                    Title = "Something Toolkit",
                    Description = "GG-4",
                    Image = "4.jpg"
                },
            };
            public static Course GetCourseById(int id)
            {
                return Courses.FirstOrDefault(u=> u.Id == id);
            }
    }
}