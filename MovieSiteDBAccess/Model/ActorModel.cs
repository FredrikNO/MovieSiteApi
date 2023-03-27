using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieSiteData.Model
{
    public class ActorModel
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public DateTime Birthdate { get; set; } = default!;

        public ActorModel()
        {
            Id= Guid.NewGuid();
        }
    }
}
