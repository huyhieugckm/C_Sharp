using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace MvcMovie.Models
{ 
    public class Cinema
    {
        public List<Movie> Movies { get; set; }
        public int CId { get; set; }
        public string CName { get; set; }

        public int MId { get; set; }
    }
}