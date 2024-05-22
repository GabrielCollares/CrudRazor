using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CsharpCRUD.Data;
using CsharpCRUD.Models;

namespace CsharpCRUD.Pages_Students
{
    public class IndexModel : PageModel
    {
        private readonly CsharpCRUD.Data.ApplicationDbContext _context;

        public IndexModel(CsharpCRUD.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
