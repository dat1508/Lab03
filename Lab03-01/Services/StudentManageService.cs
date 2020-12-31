using Lab03_01.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03_01.Services
{
    class StudentManageService
    {
        public static List<Student> GetStudent()
        {
            var list = new List<Student>();
                using (var db = new StudentContextDB())
            {
                list = db.Students.AsNoTracking().Include("Faculty").ToList();
            }
            return list;
        }
        public static List<Faculty> GetFaculty()
        {
            var list = new List<Faculty>();
            using (var db = new StudentContextDB())
            {
                list = db.Faculties.AsNoTracking().ToList();
            }
            return list;
        }

        public static void AddItem(Student student)
        {
            using (var db = new StudentContextDB())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        public static void EditItem(Student student)
        {
            using (var db = new StudentContextDB())
            {
                var studentDB = db.Students.Where(x => x.StudentID == student.StudentID).SingleOrDefault();
                studentDB.FullName = student.FullName;
                studentDB.AverageScore = student.AverageScore;
                studentDB.FacultyID = student.FacultyID;
                db.SaveChanges();
            }
        }

        public static void DeleteItem(string text)
        {
            using (var db = new StudentContextDB())
            {
                var studentDB = db.Students.Where(x => x.StudentID == text).SingleOrDefault();
                db.Students.Remove(studentDB);
                db.SaveChanges();
            }
        }

        public static bool ValidateItem(string text)
        {
            Student student = null;
            using (var db = new StudentContextDB())
            {
                student = db.Students.AsNoTracking().Where(x =>(x.StudentID == text)).FirstOrDefault();
            }
            if (student == null) return true;
            return false;
        }

        public static bool ValidateFaculty(int text)
        {
            Faculty faculty = null;
            using (var db = new StudentContextDB())
            {
                faculty = db.Faculties.AsNoTracking().Where(x => x.FacultyID == text).FirstOrDefault();
            }
            if (faculty == null) return true;
            return false;
        }

        public static void AddFaculty(Faculty faculty)
        {
            using (var db = new StudentContextDB())
            {
                db.Faculties.Add(faculty);
                db.SaveChanges();
            }
        }

        public static void EditFaculty(Faculty faculty)
        {
            using (var db = new StudentContextDB())
            {
                var facultyDB = db.Faculties.Where(x => x.FacultyID == faculty.FacultyID).SingleOrDefault();
                facultyDB.FacultyID = faculty.FacultyID;
                facultyDB.FacultyName = faculty.FacultyName;
                facultyDB.TotalProfessor = faculty.TotalProfessor;
                db.SaveChanges();
            }
        }
        public static void DeleteFaculty(int id)
        {
            using (var db = new StudentContextDB())
            {
                var facultyDB = db.Faculties.Where(x => x.FacultyID == id).SingleOrDefault();
                db.Faculties.Remove(facultyDB);
                db.SaveChanges();
            }
        }
    }
}
