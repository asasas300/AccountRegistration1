using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountRegistration1
{
    public static class StudentInfoClass
    {
        // Delegates
        public delegate long DelegateNumber(long number);
        public delegate string DelegateText(string txt);

        // Static variables
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static string MiddleName { get; set; }
        public static string Address { get; set; }
        public static string Program { get; set; }
        public static long Age { get; set; }
        public static long ContactNo { get; set; }
        public static long StudentNo { get; set; }

        // Static return type methods (accessors)
        public static string GetFirstName(string FirstName) { return FirstName; }
        public static string GetLastName(string LastName) { return LastName; }
        public static string GetMiddleName(string MiddleName) { return MiddleName; }
        public static string GetAddress(string Address) { return Address; }
        public static string GetProgram(string Program) { return Program; }
        public static long GetAge(long Age) { return Age; }
        public static long GetContactNo(long ContactNo) { return ContactNo; }
        public static long GetStudentNo(long StudentNo) { return StudentNo; }
    }
}
