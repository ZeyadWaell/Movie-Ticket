using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Entites
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public int Actor { get; set; }
        public ICollection<Actor> Actors { get; set; }

        public ICollection<Threater> Threaters { get; set; }
    }
}
