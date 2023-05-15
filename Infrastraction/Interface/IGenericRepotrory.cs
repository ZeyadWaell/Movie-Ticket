using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastraction.Interface
{
    public interface IGenericRepotrory<T>
    {
        Task<T> Get(int? id);
        Task<IEnumerable<T>> GetAll();

        Task<int> Add(T item);

        Task<int> Update(T item);

        Task<int> Delete(T item);
    }
}
