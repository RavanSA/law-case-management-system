using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1.Models;

namespace WebApp1.Pages.Davalar
{
    public class DavaSonucuModel : PageModel
    {

        public readonly HukukDTSContext _db;

        public DavaSonucuModel(HukukDTSContext db)
        {
            _db = db;
        }

        [BindProperty]
        public DavaSonucu DavaSonucu { get; set; }


        public async Task OnGet(int id)
        {
            DavaSonucu = await _db.DavaSonucu.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                await _db.DavaSonucu.AddAsync(DavaSonucu);
                await _db.SaveChangesAsync();

                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}