using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOperationCaseService
    {
        IDataResult<List<OperationCase>> GetAll();
        IDataResult<List<OperationCase>> GetById(int id);
        IResult Add(OperationCase operationCase);
        IResult Delete(OperationCase operationCase);
        IResult Uptade(OperationCase operationCase);
    }
}
