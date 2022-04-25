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
    public class OperationDetailManager : IOperationDetailService
    {

        IOperationDetailDal _operationDetailDal;

        public OperationDetailManager(IOperationDetailDal operationDetailDal)
        {
            _operationDetailDal = operationDetailDal;
        }

        public IResult Add(OperationDetail operationDetail)
        {
            _operationDetailDal.Add(operationDetail);
            return new SuccessResult("Bşarıyla eklendi");
        }

        public IResult Delete(OperationDetail operationDetail)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationDetail>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<OperationDetail>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Uptade(OperationDetail operationDetail)
        {
            throw new NotImplementedException();
        }
    }
}
