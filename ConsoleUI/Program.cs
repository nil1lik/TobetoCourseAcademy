using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entity.Concretes;
using System.Net.Http.Headers;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {

            //Category category = new Category { Id = 1, Name = "Programlama" };
            //Instructor instructor = new Instructor { Id = 1, First_Name = "engin", Last_Name = "Demiroğ" };

            //EntityManager entityManager = new EntityManager();


            CourseManager courseManager = new CourseManager(new EfCourseDal());
            var result = courseManager.GetCourseDetail();
            if (result.Success == true)
            {
                foreach (var c in result.Data)
                {
                    Console.WriteLine(c.CourseId + "-" + c.CourseName + "/" + c.CategoryName);
                }
            }

            Console.ReadKey();
            //Encapsulation eklecenecek

            //entityManager.Add(instructor,instructor.First_Name);
            //entityManager.Add(category, category.Name);

        }
    }
}