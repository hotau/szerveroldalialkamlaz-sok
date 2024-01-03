using GAMF.Data;
using GAMF.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GAMF_N.Controllers
{
    public class reportController : Controller
    {
        private readonly GAMFDbContext _Context;

        public reportController(GAMFDbContext context)
        {
            _Context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult EnrollmentDateReport()
        {
            var result = _Context.Students.GroupBy(s => s.EnrollmentDate)
                .Select(s => new EnrollmentDateVM
                {
                    EnrollmentDate = s.Key,
                    StudentCount = s.Count()
                });


            return View(result.ToList());
        }
        public class k
        {
            public int id;
            public int cr;
        }
        public IActionResult StudentCredit()
        {
            var list = new List<StudentsCreditVM>();
            int valami = 0;
            int cred = 0;

            var st = _Context.Students.ToList();
            var en = _Context.Enrollments.ToList();
            var co = _Context.Courses.ToList();
            foreach (var item in st)
            {
                var res = new StudentsCreditVM();
                res.Id = item.Id;
                res.FirstMidName = item.FirstMidName;
                res.LastName = item.LastName;
                res.kreditszam = 0;
                foreach (var item1 in en)
                {
                    if (item.Id == item1.StudentId)
                    {
                        foreach (var item2 in co)
                        {
                            if (item1.CourseId == item2.CourseId)
                            {
                                res.kreditszam += item2.Credits;
                            }
                        }
                    }
                }
                list.Add(res);
            }
            return View(list);
        }
    }
}