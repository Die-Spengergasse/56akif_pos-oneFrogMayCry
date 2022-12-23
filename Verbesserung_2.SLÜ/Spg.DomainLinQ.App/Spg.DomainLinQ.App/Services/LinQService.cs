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
            var result01 = _db.Students.SingleOrDefault(s => s.Id == 12);

            // Erstelle eine Liste aller Fächer, die eine negative Note haben.
            var result02 = _db.Subjects.Where(s => s.Exams.Any(e => e.Grade == 5)).ToList();

            // Erstelle eine Liste aller Fächer, die eine negative Note in POS haben.
            var result03 = _db.Subjects.Where(s => s.Exams.Any(e => e.Grade == 5 && e.SubjectNavigation.Description.Equals("POS"))).ToList();

            // Erstelle eine Liste aller Fächer, die nur positive Noten haben.
            var result04 = _db.Subjects.Where(s => s.Exams.All(e => e.Grade < 5)).ToList();

            // Erstelle eine Liste aller Lehrer, die POS unterrichten
            var result05 = _db.Teachers.Where(t => t.Subjects.Any(s => s.Description.Equals("POS"))).ToList();

            // Erstelle eine Liste aller Students mit einer "hotmail"-E-Mail-Adresse
            var result06 = _db.Students.Where(s => s.EMail.Contains("@hotmail")).ToList();

            // Ermittle die schlechteste Note im Fach POS
            var result07 = _db.Exams.Where(e => e.SubjectNavigation.Description.Equals("POS")).Max(e => e.Grade);

            // Ermittle den Notendurchschnitt im Fach DBI
            var result08 = _db.Exams.Where(e => e.SubjectNavigation.Description.Equals("DBI")).Average(e => e.Grade);

            Console.ReadLine();
        }
    }
}
