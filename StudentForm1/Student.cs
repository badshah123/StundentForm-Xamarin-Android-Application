using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentForm1
{
    public class Student
    {

        private static string Name;
        private static string Surname;
        private static int StudentNo;
        private static string Email;
        private static string Faculty;
        private static string PhoneNo;

        public static void setName(string name) { Name = name; }
        public static void setSurname(string surname) { Surname = surname; }
        public static void setStudentNo(int studentNo){ StudentNo = studentNo; }
        public static void setEmail(string email) { Email = email; }
        public static void setFaculty(string faculty) { Faculty = faculty; }
        public static void setPhoneNo(string phoneNo) { PhoneNo= phoneNo; }
        public static string StudentDetails()
        {
            string details;
            details = "name = " + Name + "\n";
            details += "surname = " + Surname + "\n";
            details += "student no = " + StudentNo.ToString() + "\n";
            details += "e-mail = " + Email + "\n";
            details += "faculty = " + Faculty + "\n";
            details += "phone no = " + PhoneNo;

            return details;
        }    

    }
}