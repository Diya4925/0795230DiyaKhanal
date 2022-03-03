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
    public class DeleteModel : PageModel
    {
        private readonly MyTarotDecksContext _context;

        public DeleteModel(MyTarotDecksContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            TarotCards = await _context.TarotCards.FindAsync(id);

            if (TarotCards != null)
            {
                _context.TarotCards.Remove(TarotCards);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
