using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace MovieSiteData.Model
{
    public class MovieModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = default!;
        public DateTime ReleaseDate { get; set; } = default!;
        public string MDescription { get; set; } = default!;
        public decimal Score { get; set; } = default!;
        //public string MovieType { get; set; } = default!;
        public int CategoryId { get; set; } = default!;
        public string ImageSrc { get; set; } = default!;

        public MovieModel()
        {
            Id = Guid.NewGuid();
        }
    }
}
