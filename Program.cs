// var service = new GroupStudent();
// while (true)
// {
//     System.Console.WriteLine(@"Choose any action:
// 1 - Show all students.
// 2 - Add new student.
// 3 - Delete student.");
//     var action = Console.ReadLine();
//     switch (action)
//     {
//         case "1":
//             System.Console.WriteLine("=================================All Students================================");
//             service.ShowAllStudents();
//             System.Console.WriteLine("=============================================================================");
//             break;
//         case "2":
//             System.Console.WriteLine("Enter name of student: ");
//             var name = Console.ReadLine();
//             System.Console.WriteLine("Enter lastname of student: ");
//             var lastname = Console.ReadLine();
//             System.Console.WriteLine("Enter course of student: ");
//             var course = Convert.ToInt32(Console.ReadLine());
//             var student = new Student()
//             {
//                 Name = name,
//                 LastName = lastname,
//                 Course = course
//             };
//             service.CreateStudent(student);
//             System.Console.WriteLine("Added new student.");
//             break;
//         case "3":
//             System.Console.WriteLine("Enter id to delete: ");
//             var idOfStudent = Convert.ToInt32(Console.ReadLine());
//             service.DeleteStudent(idOfStudent);
//             System.Console.WriteLine("Removed student.");
//             break;
//         default:
//             System.Console.WriteLine("Action not found!");
//             break;    

//     }
// }

var service = new GroupCourse();
while (true)
{
    System.Console.WriteLine(@"Choose any action:
1 - Show all courses.
2 - Add new course.
3 - Delete course.");
    var action = Console.ReadLine();
    switch (action)
    {
        case "1":
            System.Console.WriteLine("=================================All Courses================================");
            service.ShowAllCourses();
            System.Console.WriteLine("=============================================================================");
            break;
        case "2":
            System.Console.WriteLine("Enter title of course: ");
            var title = Console.ReadLine();
            System.Console.WriteLine("Enter direction of course: ");
            var direction = Console.ReadLine();
            System.Console.WriteLine("Enter students count: ");
            var studentsCount = Convert.ToInt32(Console.ReadLine());
            var course = new Course()
            {
                Title = title,
                Direction = direction,
                StudentsCount = studentsCount
            };
            service.CreateCourse(course);
            System.Console.WriteLine("Added new course.");
            break;
        case "3":
            System.Console.WriteLine("Enter id to delete: ");
            var idOfCourse = Convert.ToInt32(Console.ReadLine());
            service.DeleteCourse(idOfCourse);
            System.Console.WriteLine("Removed course.");
            break;
        default:
            System.Console.WriteLine("Action not found!");
            break;    

    }
}
