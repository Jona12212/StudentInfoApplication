using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInfoApplication
{
    public class StudentInfo
    { // Private instance variables
        private string firstName;
        private string lastName;
        private string studentID;

        // Default constructor
        public StudentInfo()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            studentID = string.Empty;
        }

        // Overloaded constructor
        public StudentInfo(string firstName, string lastName, string studentID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.studentID = studentID;
        }

        // Properties for encapsulation
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string StudentID
        {
            get { return studentID; }
            set { studentID = value; }
        }
    }
}
    

