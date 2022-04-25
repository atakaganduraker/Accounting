using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOperationTypeService
    {
        IDataResult<List<OperationType>> GetAll();
        IDataResult<List<OperationType>> GetById(int id);
        IResult Add(OperationType operationType);
        IResult Delete(OperationType operationType);
        IResult Uptade(OperationType operationType);
    }
}
