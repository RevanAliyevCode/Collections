using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTask
{
    public class Students
    {
        public Dictionary<string, List<int>> Grades { get; } = [];

        public void AddGrade(string name, params int[] grades)
        {
            if (!Grades.ContainsKey(name)) Grades[name] = new List<int>(grades);
            else Grades[name].AddRange(grades);
        }

        public void RemoveGrade(string name, params int[] grades)
        {
            if (Grades.ContainsKey(name)) foreach (int i in grades) Grades[name].Remove(i);
            else Console.WriteLine("There is not such a student");
        }

        public int GetAverageGrade(string name)
        {
            if(Grades.ContainsKey(name))
            {
                int sum = 0;

                foreach (int i in Grades[name]) sum += i;

                return sum / Grades[name].Count;
            }

            return -1;
        }

        public void GetAllGradesByStudents(string name)
        {
            if (Grades.ContainsKey(name))
            {
                Console.Write($"{name}:");
                foreach (int grade in Grades[name])
                {
                    Console.Write($" {grade}");
                }
            }
            else Console.WriteLine("There is no such a student");
        }
    }
}
