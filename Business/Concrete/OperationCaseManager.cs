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
    public class OperationCaseManager : IOperationCaseService
    {

        IOperationCaseDal _operationCaseDal ;

        public OperationCaseManager(IOperationCaseDal operationCaseDal)
        {
            _operationCaseDal = operationCaseDal;
        }

        public IResult Add(OperationCase operationCase)
        {
            _operationCaseDal.Add(operationCase);
            string id =operationCase.OperationCaseId.ToString();
            return new SuccessResult(id);
        }

        public IResult Delete(OperationCase operationCase)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationCase>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationCase>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Uptade(OperationCase operationCase)
        {
            throw new NotImplementedException();
        }
    }
}
