using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyTarotDecks.Models;

namespace web315.Pages_TarotDecks
{
    public class CreateModel : PageModel
    {
        private readonly MyTarotDecksContext _context;

        public CreateModel(MyTarotDecksContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public TarotCards TarotCards { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.TarotCards.Add(TarotCards);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
