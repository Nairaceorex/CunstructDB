﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ConstructDB.Models;
using CunstructDB.Data;

namespace CunstructDB.Pages.TypeOfJobs
{
    public class DetailsModel : PageModel
    {
        private readonly CunstructDB.Data.CunstructDBContext _context;

        public DetailsModel(CunstructDB.Data.CunstructDBContext context)
        {
            _context = context;
        }

        public TypeOfJob TypeOfJob { get; set; }

        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TypeOfJob = await _context.TypeOfJob.FirstOrDefaultAsync(m => m.ID == id);

            if (TypeOfJob == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
