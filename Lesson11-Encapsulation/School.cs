namespace Lesson11_Encapsulation;

public class School
{
    string[] Schedule = new string[11];
    public List<Teacher> Teachers = new List<Teacher>();
    List<Student> Students = new List<Student>();

    public School(List<Teacher> teachers, List<Student> students)
    :this() {
        Teachers = teachers;
        Students = students;
    }

    public School()
    {
        Random random = new Random();
        for (int i = 0; i < Schedule.Length; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Schedule[i] += $"Day {j + 1}\n";
                for (int k = 0; k < 4; k++)
                {
                    Schedule[i] += (Classes)random.Next(5);
                    Schedule[i] += " ";
                }

                Schedule[i] += '\n';
            }
        }
    }

    public void ShowSchedule()
    {
        for (int i = 0; i < Schedule.Length; i++)
        {
            Console.WriteLine($"Grade {i + 1}:\n");
            Console.WriteLine(Schedule[i]);
        }
    }

    public void ShowTeachers()
    {
        foreach (var teacher in Teachers)
        {
            teacher.ShowInfo();
        }    
    }

    public void ShowStudents()
    {
        foreach (var student in Students)
        {
            student.ShowInfo();
        }
    }
    
    public void AddTeacher(Teacher teacher)
    {
        Teachers.Add(teacher);
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }
}