using Core.Utilities.Result;
using Entity.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        IResult Add (Instructor instructor);
        IResult Update(Instructor instructor);
        IResult Delete(Instructor instructor);
        IDataResult<List<Instructor>> GetAll(); //
    }
}
