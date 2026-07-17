public class GroupStudent
{
    private List<Student> students = new();
    public void CreateStudent(Student student)
    {
        if (students.Count == 0)
        {
            student.Id = 1;

        }
        else
        {
            student.Id = students[students.Count - 1].Id + 1;
        }
        students.Add(student);
    }
    public void DeleteStudent(int id)
    {
        var todelete = new Student();
        for (int i = 0; i < students.Count; i++)
        {
            if (students[i].Id == id)
            {
                todelete = students[i];
            }
        }
        students.Remove(todelete);
    }
    public void ShowAllStudents()
    {
        for (int i = 0; i < students.Count; i++)
        {
            var student = students[i];
            System.Console.WriteLine(student.Id + " " + student.Name + " " + student.Course + " " + student.LastName);
        }
        
    }   
}

