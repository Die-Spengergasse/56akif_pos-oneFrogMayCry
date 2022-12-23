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
        public string Firstname { get; set; } = string.Empty;
        public string Lastname { get; set; } = string.Empty;
        public string EMail { get; set; } = string.Empty;
        public Address Address { get; set; } = default!;
        public Gender Gender { get; set; }
        public Guid Guid { get; set; }

        private List<Subject> _subjects = new();
        public virtual IReadOnlyList<Subject> Subjects => _subjects;

        protected Teacher()
        { }

        public Teacher(string firstname, string lastname, string eMail, Gender gender, Guid guid, Address address)
        {
            Firstname = firstname;
            Lastname = lastname;
            EMail = eMail;
            Address = address;
            Gender = gender;
            Guid = guid;
        }

        public void AddSubject(Subject subject)
        {
            _subjects.Add(subject);
        }
    }
}
