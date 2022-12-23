using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
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
        public Guid Guid { get; set; }
        public DateTime? Date { get; set; }
        public int? Lesson { get; set; }
        public int Grade 
        {
            get { return Grade; }
            set
            {
                if(value < 1 || value > 5)
                {
                    throw new ArgumentException("Grade must be between 1 and 5!");
                }
                Grade = value;
            }
        }
        public int SubjectNavigationId { get; set; }
        public virtual Subject SubjectNavigation { get; set; } = default!;
        public DateTime Created { get; set; }

        protected Exam() 
        { }

        public Exam(Guid guid, DateTime? date, int? lesson, int grade, Subject subject, DateTime created)
        {
            Guid = guid;
            Date = date;
            Lesson = lesson;
            Grade = grade;
            SubjectNavigation = subject;
            Created = created;
        }
    }
}
