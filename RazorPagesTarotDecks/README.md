# Diya_Khanal_Web315
 
 dotnet new webApp -o MyTarotDecks --no-https
 dotnet dev-certs https --trust
dotnet tool install --global dotnet-ef --version 5.*
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*
dotnet-aspnet-codegenerator razorpage -m TarotCards -dc MyTarotDecksContext -udl -outDir Pages/TarotDecks --referenceScriptLibraries -sqlite
dotnet ef migrations add InitialCreate
dotnet ef database update


var TarotCards = from m in _context.TarotCards
                 select m;
    if (!string.IsNullOrEmpty(SearchString))
    {
        TarotCards = TarotCards.Where(s => s.Title.Contains(SearchString));
    }

    TarotCards = await TarotCards.ToListAsync();