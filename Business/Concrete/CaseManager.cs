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
    public class CaseManager : ICaseService
    {
        ICaseDal _caseDal;

        public CaseManager(ICaseDal caseDal)
        {
            _caseDal = caseDal;
        }

        public IResult Add(Case casee)
        {
            _caseDal.Add(casee);
            string id = casee.Id.ToString();
            return new SuccessResult(id + " Başarıyla eklinde ");
        }

       

        public IResult Delete(Case casee)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Case>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Case>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Uptade(Case casee)
        {
            throw new NotImplementedException();
        }

        

        IDataResult<List<Case>> ICaseService.GetAll()
        {
            throw new NotImplementedException();
        }

        IDataResult<List<Case>> ICaseService.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
