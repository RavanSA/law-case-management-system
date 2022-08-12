using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp1.Models;

namespace WebApp1.Pages.Davalar
{
    public class GuncelleYerelMahkemeKarariModel : PageModel
    {
        public readonly HukukDTSContext _db;

        public GuncelleYerelMahkemeKarariModel(HukukDTSContext db)
        {
            _db = db;
        }

        [BindProperty]
        public YerelMahkemeKarari Karar { get; set; }

        public async Task OnGet(int id)
        {
            Karar = await _db.YerelMahkemeKarari.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                //var KararDB = await _db.YerelMahkemeKarari.FindAsync(Karar.DavaKayitNo);


                //KararDB.KararNo = Karar.KararNo;
                //KararDB.KararTarihi = Karar.KararTarihi;
                //KararDB.KararSonucu = Karar.KararSonucu;
                //KararDB.KararOzeti = Karar.KararOzeti;
                await _db.YerelMahkemeKarari.AddAsync(Karar);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");

            } else
            {
                return Page();
            }
        }
    }
}
