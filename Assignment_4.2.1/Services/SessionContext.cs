using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_4._2._1.Services
{
    internal static class SessionContext
    {
        public static string UserName { get; private set; }
        public static Role UserRole { get; private set; }
        public static Student CurrentStudent { get; private set; }
        public static Teacher CurrentTeacher { get; private set; }

        public static void StartSession(string userName, Role role)
        {
            UserName = userName;
            UserRole = role;
        }

        public static void SetStudent(Student student)
        {
            CurrentStudent = student;
            CurrentTeacher = null;
        }

        public static void SetTeacher(Teacher teacher)
        {
            CurrentTeacher = teacher;
            CurrentStudent = null;
        }

        public static void Clear()
        {
            UserName = null;
            UserRole = Role.None;
            CurrentStudent = null;
            CurrentTeacher = null;
        }
    }
}
