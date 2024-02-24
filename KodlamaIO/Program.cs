using KodlamaIO.Business.Concrete;
using KodlamaIO.DataAccess.Concrete;
using KodlamaIO.Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("-------Get All Courses--------");
        CourseManager courseManager = new(new CourseDal());
        
        List<Course> courses = courseManager.GetAll();
        Console.WriteLine(courses);
        for (int i = 0; i < courses.Count; i++)
        {
            Console.WriteLine(courses[i].Name+"/"+ courses[i].Description);
        }

        //Add Course
        courseManager.Add(new Course()
        {
            Id = 5,
            CategoryId = 1,
            InstructorId = 1,
            Name = "Kotlin İle Mobil Uygulama",
            Description = "New.. Course",
            Percentage = 0
        }) ;
        Console.WriteLine("-------New Course Added and Get All Courses--------");

        for (int i = 0; i < courses.Count; i++)
        {
            Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
        }

        //Update Course
        Console.WriteLine("------- Course Updated and Get All Courses--------");

        courseManager.Update(new Course()
        {
            Id = 5,
            CategoryId = 1,
            InstructorId = 1,
            Name = "Java ve Kotlin İle Mobil Uygulama",
            Description="Updated",
            Percentage = 0
        });
        for (int i = 0; i < courses.Count; i++)
        {
            Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
        }

        Console.WriteLine("------- Get Id By Course--------");
        Console.WriteLine(courseManager.Get(5).Name);

        Console.WriteLine("------- Delete Course--------");
        courseManager.Delete(5);
        for (int i = 0; i < courses.Count; i++)
        {
            Console.WriteLine(courses[i].Name + "/" + courses[i].Description);
        }
    }
}