using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Interface
{
    public interface IUniteOfWork
    {
        public IMovieRepostory MovieRepostory { get; set; }
    }
}
