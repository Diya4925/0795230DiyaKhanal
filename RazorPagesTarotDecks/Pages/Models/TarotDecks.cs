using System;
using System.ComponentModel.DataAnnotations;

namespace MyTarotDecks.Models
{
    public class TarotCards
    {
        public int ID { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Theme { get; set; }
        public decimal Price { get; set; }
    }

    
}