using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Date (?)
    /// * Lesson (int?)
    /// * Created
    /// * Guid
    /// * Grade (Note 1-5)
    /// (4P)
    /// </summary>
    public class Exam : EntityBase
    {
        // TODO: Implementation
        public DateTime? Date { get; set; }
        public int? Lesson { get; set; }
        public DateTime Created { get; set; }
        public Guid Guid { get; set; }
        public int Grade 
        { 
            get => _grade;
            set
            {
                if(value < 1 || value > 5)
                    throw new ArgumentOutOfRangeException("Note muss zwischen 1 und 5 liegen!");
                _grade = value;
            }
        }
        private int _grade;
        public int SubjectNavigationId { get; set; }
        public Subject SubjectNavigation { get; set; } = default!;

        protected Exam()
        { }
        public Exam(Guid guid, DateTime? date, int? lesson, int grade, Subject subjectNavigation, DateTime created)
        {
            Date = date;
            Lesson = lesson;
            Created = created;
            Guid = guid;
            Grade = grade;
            SubjectNavigation = subjectNavigation;
        }
    }
}
