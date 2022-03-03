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
    public class IndexModel : PageModel
    {
        private readonly MyTarotDecksContext _context;

        public IndexModel(MyTarotDecksContext context)
        {
            _context = context;
        }

        public IList<TarotCards> TarotCards{ get;set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Theme { get; set; }
        [BindProperty(SupportsGet = true)]
        public string TarotCardsTheme { get; set; }

        public async Task OnGetAsync()
        {
            // Use LINQ to get list of genres.
    IQueryable<string> genreQuery = from m in _context.TarotCards
                                    orderby m.Theme
                                    select m.Theme;

    var TarotDecks = from m in _context.TarotCards
                 select m;

    if (!string.IsNullOrEmpty(SearchString))
    {
        TarotDecks = TarotDecks.Where(s => s.Title.Contains(SearchString));
    }

    if (!string.IsNullOrEmpty(TarotCardsTheme))
    {
        TarotDecks = TarotDecks.Where(x => x.Theme == TarotCardsTheme);
    }
    Theme = new SelectList(await genreQuery.Distinct().ToListAsync());
    TarotDecks = await TarotCards.ToListAsync();
}
    }
}
