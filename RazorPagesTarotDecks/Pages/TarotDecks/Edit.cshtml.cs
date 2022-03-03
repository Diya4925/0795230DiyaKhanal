using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyTarotDecks.Models;

namespace web315.Pages_TarotDecks
{
    public class EditModel : PageModel
    {
        private readonly MyTarotDecksContext _context;

        public EditModel(MyTarotDecksContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TarotCards).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarotCardsExists(TarotCards.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TarotCardsExists(int id)
        {
            return _context.TarotCards.Any(e => e.ID == id);
        }
    }
}
