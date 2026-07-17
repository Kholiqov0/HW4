public class GroupCourse
{
    private List<Course> courses = new();
    public void CreateCourse(Course course)
    {
        if (courses.Count == 0)
        {
            course.Id = 1;

        }
        else
        {
            course.Id = courses[courses.Count - 1].Id + 1;
        }
        courses.Add(course);
    }
    public void DeleteCourse(int id)
    {
        var todelete = new Course();
        for (int i = 0; i < courses.Count; i++)
        {
            if (courses[i].Id == id)
            {
                todelete = courses[i];
            }
        }
        courses.Remove(todelete);
    }
    public void ShowAllCourses()
    {
        for (int i = 0; i < courses.Count; i++)
        {
            var course = courses[i];
            System.Console.WriteLine(course.Id + " " + course.Title + " " + course.Direction + " " + course.StudentsCount);
        }
        
    }   
}

