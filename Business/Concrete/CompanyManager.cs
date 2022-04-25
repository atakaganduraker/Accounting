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
    public class CompanyManager : ICompanyService
    {

        ICompanyDal _companyDal;

        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            string id = company.CompanyId.ToString();
            return new SuccessResult(id + "Başarıyla eklendi");
        }

        public IResult Delete(Company company)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Company>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Company>> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Uptade(Company company)
        {
            throw new NotImplementedException();
        }
    }
}
