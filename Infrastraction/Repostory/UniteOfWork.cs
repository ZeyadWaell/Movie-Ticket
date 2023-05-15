using Infrastraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Repostory
{
    public class UniteOfWork : IUniteOfWork
    {
 
        public UniteOfWork(IMovieRepostory movieRepostory)
        {;
            movieRepostory = MovieRepostory;
        }
        public IMovieRepostory MovieRepostory { get;set; }
    }
}
