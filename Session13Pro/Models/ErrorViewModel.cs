using System;
using System.Collections.Generic;

namespace Session13Pro.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }

    public class Student
    {
        public Student()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public interface IStudentRepositry
    {
        List<Student> GetAll();
    }

    public class StudentRepositry: IStudentRepositry
    {
        public List<Student> data;
        public StudentRepositry()
        {
            data = new List<Student>();
            data.Add(new Student() { Name = "amir" });
            data.Add(new Student() { Name = "reza" });
        }
        public List<Student> GetAll() => data;
    }
}