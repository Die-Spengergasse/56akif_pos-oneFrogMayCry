using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Model
{
    /// <summary>
    /// * Name
    /// * Department [Die ersten 3 Zeichen von Name]
    /// * Guid
    /// (4P)
    /// </summary>
    public class SchoolClass : EntityBase
    {
        // TODO: Implementation
        public Guid Guid { get; set; }
        public string Name { get; set; } = string.Empty;
        public Teacher? Kv { get; set; }
        public string Department => Name.Substring(0, 3);

        private List<Student> _students = new();
        public virtual IReadOnlyList<Student> Students => _students;

        private List<Teacher> _teacher = new();
        public virtual IReadOnlyList<Teacher> Teachers => _teacher; 


        protected SchoolClass() 
        { }
        
        public SchoolClass(string name, Teacher teacher, Guid guid)
        {
            Name= name;
            Kv = teacher;
            Guid = guid;
        }
    }
}
