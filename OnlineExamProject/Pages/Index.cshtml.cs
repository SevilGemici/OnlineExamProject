using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnlineExamProject.Models;

namespace OnlineExamProject.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ExamContext _ob;

        public IndexModel(ExamContext ob)
        {
            _ob = ob;
        }
        public IEnumerable<Exam> result { get; set; }
        public async Task OnGet()
        {
            result = await _ob.exam.ToListAsync();
        }
    }
}
