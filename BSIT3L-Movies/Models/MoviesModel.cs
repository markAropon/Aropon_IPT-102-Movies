using System;
namespace BSIT3L_Movies.Models
{
    
	public class MovieViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Rating { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string imageUrl { get; set; }
        public string trailer { get; set; }
        public string description { get; set; }
        
    }
}

