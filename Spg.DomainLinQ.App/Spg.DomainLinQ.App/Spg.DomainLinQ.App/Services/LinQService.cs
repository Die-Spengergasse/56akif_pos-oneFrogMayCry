using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Spg.DomainLinQ.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.DomainLinQ.App.Services
{
    /// <summary>
    /// (8P)
    /// </summary>
    public class LinQService
    {
        private readonly School2000Context _db;
        public LinQService(School2000Context db)
        {
            _db = db;
        }

        public void Start()
        {
            // Gebe jenen Student mit der ID=12 zurück.
            var result01 = _db.Students.SingleOrDefault(x => x.Id == 12);

            // Erstelle eine Liste aller Fächer, die eine negative Note haben.
            var result02 = _db.Subjects
                .Include(x => x.Exams
                    .Where(x => x.Grade == 5));


            // Erstelle eine Liste aller Fächer, die eine negative Note in POS haben.
            var result03 = _db.Subjects.Where(x => x.Exams.Any(x => x.Grade == 5));

            // Erstelle eine Liste aller Fächer, die nur positive Noten haben.
            var result04 = _db.Subjects.Include(x => x.Exams.All(x => x.Grade < 5));

            // Erstelle eine Liste aller Lehrer, die POS unterrichten
            var result05 = _db.Teachers
                .Include(x => x.Subjects
                    .Where(x => x.Equals("POS")));

            // Erstelle eine Liste aller Students mit einer "hotmail"-E-Mail-Adresse
            var result06 = _db.Students.Where(x => x.EMail.Contains("@hotmail"));

            // Ermittle die schlechteste Note im Fach POS
            var result07 = _db.Subjects.Include(x => x.Exams.Where(x => x.SubjectNavigation.Description.Equals("POS")).Max(x => x.Grade));

            // Ermittle den Notendurchschnitt im Fach DBI
            var result08 = _db.Subjects.Include(x => x.Exams.Where(x => x.SubjectNavigation.Description.Equals("DBI")).Average(x => x.Grade));
        }
    }
}
