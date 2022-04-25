using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRatioService
    {
        IDataResult<List<Ratio>> GetAll();
        IDataResult<List<Ratio>> GetById(int id);
        IResult Add(Ratio ratio);
        IResult Delete(Ratio ratio);
        IResult Uptade(Ratio ratio);
    }
}
