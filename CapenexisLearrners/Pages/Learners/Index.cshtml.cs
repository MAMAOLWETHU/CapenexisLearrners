using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CapenexisLearrners.Data;
using CapenexisLearrners.Models;

namespace CapenexisLearrners.Pages.Learners
{
    public class IndexModel : PageModel
    {
        private readonly CapenexisLearrners.Data.CapenexisLearrnersContext _context;

        public IndexModel(CapenexisLearrners.Data.CapenexisLearrnersContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Movie != null)
            {
                Movie = await _context.Movie.ToListAsync();
            }
        }
    }
}
