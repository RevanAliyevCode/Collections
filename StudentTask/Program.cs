// See https://aka.ms/new-console-template for more information

using StudentTask;

Students students = new();

students.AddGrade("Revan", 78, 89, 9);

students.RemoveGrade("Revan", 9);
students.GetAllGradesByStudents("Revan");