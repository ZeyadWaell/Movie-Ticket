using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Entites
{
    public class Threater
    {
        public int Id { get; set; }

        [DataType(DataType.Text)]
        public string Name { get; set; }

        public bool IsAviable { get; set; }
        public string Location { get; set; }
        public int Capacity { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
