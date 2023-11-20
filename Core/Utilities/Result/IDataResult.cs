using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Result
{
    public interface IDataResult<T> :IResult
    {
        //List gibi
        T Data { get; }
    }
}
