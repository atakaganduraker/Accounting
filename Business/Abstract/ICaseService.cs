using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICaseService
    {
        IDataResult<List<Case>> GetAll();
        IDataResult<List<Case>> GetById(int id);
        IResult Add(Case casee);
        IResult Delete(Case casee);
        IResult Uptade(Case casee);
    }
}
