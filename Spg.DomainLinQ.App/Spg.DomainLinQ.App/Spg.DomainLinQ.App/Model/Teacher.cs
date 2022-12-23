using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * FirstName
    /// * LastName
    /// * EMail
    /// * Address
    /// * Gender
    /// * Guid
    /// (4P)
    /// </summary>
    public class Teacher : EntityBase
    {
        // TODO: Implementation
        public Guid Guid { get; set; }
        public string Firstname { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address? Address { get; set; }
        public Gender Gender { get; set; }


        private List<Subject> _subjects = new();
        public virtual IReadOnlyList<Subject> Subjects => _subjects;

        protected Teacher() 
        { }

        public Teacher(string firstName, string lastName, string eMail, Gender gender, Guid guid, Address address)
        {
            Guid = guid;
            Firstname = firstName;
            LastName = lastName;
            EMail = eMail;
            Address = address;
            Gender = gender;
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
