using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICaseRatioService
    {
        IDataResult<List<CaseRatio>> GetAll();
        IDataResult<List<CaseRatio>> GetById(int id);
        IResult Add(CaseRatio caseRatio);
        IResult Delete(CaseRatio caseRatio);
        IResult Uptade(CaseRatio caseRatio);

    }
}
