using System;
using System.Globalization;

namespace Methods.Models
{
    public class Student
    {
        private const string DateFormat = "dd.MM.yyyy";
        private const int DateFormatLength = 10;

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime thisStudentBirthDate = this.ExtractBirthDate(this.OtherInfo);
            DateTime otherStudentBirthDate = this.ExtractBirthDate(other.OtherInfo);

            return thisStudentBirthDate > otherStudentBirthDate;
        }

        private DateTime ExtractBirthDate(string otherInfo)
        {
            DateTime birthdayDateTime;
            string birthdayString = otherInfo.Substring(otherInfo.Length - DateFormatLength);

            try
            {
                birthdayDateTime = DateTime.ParseExact(birthdayString, DateFormat, CultureInfo.InvariantCulture);
            }
            catch (Exception)
            {
                throw new ArgumentException("Invalid birthdate string provided.");
            }

            return birthdayDateTime;
        }
    }
}
