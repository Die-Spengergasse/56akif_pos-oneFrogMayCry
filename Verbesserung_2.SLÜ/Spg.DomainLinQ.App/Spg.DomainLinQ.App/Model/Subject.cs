using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Description
    /// (4P)
    /// </summary>
    public class Subject : EntityBase
    {
        // TODO: Implementation
        public string Description { get; set; } = string.Empty;

        private List<Student> _students = new();
        public virtual IReadOnlyList<Student> Students => _students;

        private List<Exam> _exams = new();
        public virtual IReadOnlyList<Exam> Exams => _exams;

        private List<Teacher> _teachers = new();
        public virtual IReadOnlyList<Teacher> Teachers => _teachers;

        public int SchoolClassNavigationId { get; set; }
        public SchoolClass SchoolClassNavigation { get; set; } = default!;

        protected Subject()
        { }
        public Subject(string description, SchoolClass schoolClassNavigation)
        {
            Description = description;
            SchoolClassNavigation = schoolClassNavigation;
        }


    }
}
