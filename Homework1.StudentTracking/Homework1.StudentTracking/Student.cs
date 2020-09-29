using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1.StudentTracking
{
    public class Student
    {
        public Student(string firstName, string lastName, string id, bool isWaResident, string major, DateTime applicationDate) //constructor
        {
            FirstName = firstName;
            LastName = lastName;
            StudentID = id;
            IsWaResident = isWaResident;
            Major = major;
            ApplicationDate = applicationDate;
        }
        private string firstName; //backing variable. private to protect data. allows you to control how user interacts with it.
        public string FirstName
        {
            get { return firstName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("First Name is Requried.");
                }
                firstName = value; // value that user passes through
            }
        }
        private string lastName; //backing variable.
        public string LastName
        {
            get { return lastName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Last Name is Required.");
                }
                lastName = value;
            }
        }
        private string studentID;
        public string StudentID
        {
            get { return studentID; }
            set
            {
                if (value.Length == 10)
                {
                    foreach (char character in value)
                    {
                        if (!char.IsDigit(character)) //can only contain digits(integers), no other characters 
                        {
                            throw new Exception("Student ID can only be digits.");
                        }
                    }
                    studentID = value; //storing value in student id 
                }
                else //if value length is less than 10 or greater than 10 check
                {
                    throw new Exception("Student ID must be ten digits.");
                }
            }
        }
        public bool IsWaResident { get; set; } //autoproperty 

        private string major;
        public string Major
        {
            get => major; //able to use this way instead of using return, "expression body", only works with single line
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Major must be selected.");
                }
                List<string> validMajors = new List<string> //collection of strings
                { //object initializer
                    "computer programming",
                    "database management",
                    "other",
                    "undecided"
                };
                if (!validMajors.Contains(value.ToLower())) //if not valid major
                {
                    throw new Exception("Valid majors include Computer Programming, Database Managament, Other, or Undecided.");
                }
                major = value;
            }

        }
        private DateTime applicationDate;
        public DateTime ApplicationDate
        {
            get => applicationDate;
            set
            {
                if (value > DateTime.Now || value <= (new DateTime(1964, 9, 1)))//checking validation for date
                {
                    throw new Exception("Application date must be be today or before, and after 9/1/1964.");
                }
                applicationDate = value;
            }
        }
        //allows for collapsable sections (region/endregion)
        #region optional 

        private string emailAddress;
        private string EmailAddress
        {
            get => emailAddress;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || !value.Contains("@"))
                {
                    throw new Exception("Must be a valid email.");
                }
                emailAddress = value;

            }
        }
        private string phoneNumber;
        public string PhoneNumber
        {
            get => phoneNumber;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length != 9)
                {
                    throw new Exception("Must be a valid 9 digit phone number.");
                }
                else
                {
                    foreach (char character in value)
                    {
                        if (!char.IsDigit(character))
                        {
                            throw new Exception("Phone number can only be digits.");
                        }
                    }
                }
                phoneNumber = value;
            }
        }
        public DateTime Birthday { get; set; }

        #endregion optional

        public string FullName => FirstName + " " + LastName; //concat. operand full name
        public string ContactInfo
        {
            get
            {
                return $"{PhoneNumber} - {EmailAddress}"; //working with string interpolation
            }
        }
        public int Age
        {
            get
            {
                return (int)(((DateTime.Now - Birthday).TotalDays) / 365.2425);
            }
        }
    }
}
