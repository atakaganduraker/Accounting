using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOperationDetailService
    {
        IDataResult<List<OperationDetail>> GetAll();
        IDataResult<List<OperationDetail>> GetById(int id);
        IResult Add(OperationDetail operationDetail);
        IResult Delete(OperationDetail operationDetail);
        IResult Uptade(OperationDetail operationDetail);
    }
}
