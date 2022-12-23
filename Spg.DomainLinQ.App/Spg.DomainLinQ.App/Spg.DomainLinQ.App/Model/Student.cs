using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * RegistrationNumber
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * PhoneNumber
    /// * AccountName = [Die ersten 5 Stellen des LastName + RegistrationNumber]
    /// * Gender
    /// * Guid
    /// (4P)s
    /// </summary>
    public class Student : EntityBase
    {
        // TODO: Implementation
        public Guid Guid { get; set; }
        public int RegistrationNumber { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public PhoneNumber? Phonenumber { get; set; }
        public string Accountname => $"{LastName.Substring(0, 5)}{RegistrationNumber}";
        public Gender Gender { get; set; }
        public Address? Address { get; set; }
        public int SchoolClassNavigationId { get; set; }
        public virtual SchoolClass SchoolClassNavigation { get; set; }

        private List<Subject> _subs = new();
        public virtual IReadOnlyList<Subject> Subjects => _subs;

        protected Student() 
        { }

        public Student(int registrationNumber, Guid guid, string firstName, string lastName, string eMail, Gender gender, SchoolClass schoolClass, Address address, PhoneNumber phonenumber)
        {
            Guid = guid;
            RegistrationNumber = registrationNumber;
            Firstname = firstName;
            LastName = lastName;
            EMail = eMail;
            Phonenumber = phonenumber;
            Address = address;
            Gender = gender;
        }




        public void AddSubjects(List<Subject> subjects)
        {
            _subs.AddRange(subjects);
        }
    }
}
