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
    public class RatioManager : IRatioService
    {
        IRatioDal _ratioDal;

        public RatioManager(IRatioDal ratioDal)
        {
            _ratioDal = ratioDal;
        }

        public IResult Add(Ratio ratio)
        {
            _ratioDal.Add(ratio);
            return new  SuccessResult("");
        }

        public IResult Delete(Ratio ratio)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Ratio>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Ratio>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Uptade(Ratio ratio)
        {
            throw new NotImplementedException();
        }
    }
}
