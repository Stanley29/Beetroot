using Lesson11_Encapsulation;

School a = new School();

Teacher b = new Teacher(Classes.Geography, 25, "Marta", "Who");
a.AddTeacher(b);
a.ShowTeachers();
a.AddStudent(new Student(18, "Denis", "Drobin"));
a.ShowStudents();
a.ShowSchedule();
a.Teachers[a.Teachers.IndexOf(b)].ChangeInfo("Ben", "Which", Classes.History);
a.ShowTeachers();
//checked
