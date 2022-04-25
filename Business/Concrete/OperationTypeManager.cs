using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class OperationTypeManager : IOperationTypeService
    {
        IOperationTypeDal _operationTypenDal;

        public OperationTypeManager(IOperationTypeDal operationTypenDal)
        {
            _operationTypenDal = operationTypenDal;
        }

        public IResult Add(OperationType operationType)
        {
            _operationTypenDal.Add(operationType);
            return new SuccessResult("");
        }

        public IResult Delete(OperationType operationType)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationType>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationType>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Uptade(OperationType operationType)
        {
            throw new NotImplementedException();
        }
    }
}
