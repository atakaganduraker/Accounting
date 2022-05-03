using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOperationService
    {
        IDataResult<List<Operation>> GetAll();
        IDataResult<List<Operation>> GetById(int id);
        IResult Add(Operation operation);
        IResult Delete(Operation operation);    
        IResult Uptade(Operation operation); 
        IResult DeleteById(int id);
    }
}
