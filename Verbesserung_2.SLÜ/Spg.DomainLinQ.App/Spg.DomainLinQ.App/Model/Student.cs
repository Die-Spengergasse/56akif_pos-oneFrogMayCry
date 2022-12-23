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
        public int RegistrationNumber { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;
        public PhoneNumber PhoneNumber { get; set; } = default!;
        public string AccountName => $"{Lastname.Substring(0, 5)}{RegistrationNumber}";
        public Gender Gender { get; set; }
        public Guid Guid { get; set; }
        public int SchoolClassNavigationId { get; set; }
        public virtual SchoolClass SchoolClassNavigation { get; set; } = default!;

        private List<Subject> _subjects = new();
        public virtual IReadOnlyList<Subject> Subjects => _subjects;

        protected Student()
        { }
        public Student(int registrationNumber, Guid guid, string firstname, string lastname, string eMail, Gender gender, SchoolClass schoolClassNavigation, Address address, PhoneNumber phoneNumber)
        {
            RegistrationNumber = registrationNumber;
            Firstname = firstname;
            Lastname = lastname;
            EMail = eMail;
            Address = address;
            PhoneNumber = phoneNumber;
            Gender = gender;
            Guid = guid;
            SchoolClassNavigation = schoolClassNavigation;
        }

        public void AddSubjects(List<Subject> subjects)
        {
            _subjects.AddRange(subjects);
        }
    }
}
