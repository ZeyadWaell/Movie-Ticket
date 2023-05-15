using Infrastraction.Entites;
using Infrastraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Repostory
{
    public class MovieRepostory:GenericRepostory<Movie> ,IMovieRepostory
    {
        private readonly MVContext _context;
        public MovieRepostory(MVContext context) : base(context)
        {
            _context = context;

        }
    }
}
