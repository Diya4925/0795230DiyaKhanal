using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyTarotDecks.Models;

namespace web315.Pages_TarotDecks
{
    public class DetailsModel : PageModel
    {
        private readonly MyTarotDecksContext _context;

        public DetailsModel(MyTarotDecksContext context)
        {
            _context = context;
        }

        public TarotCards TarotCards { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TarotCards = await _context.TarotCards.FirstOrDefaultAsync(m => m.ID == id);

            if (TarotCards == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
