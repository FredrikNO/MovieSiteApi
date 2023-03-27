using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSiteData.Model
{
    public class MovieActorModel
    {
        public Guid MovieId { get; set; }
        public Guid ActorId { get; set; }
    }
}
