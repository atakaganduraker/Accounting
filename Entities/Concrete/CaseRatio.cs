using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CaseRatio:IEntity
    {
        public int CaseRatioId { get; set; }
        public int CaseId { get; set; }
        public int RatioId { get; set; }

    }
}
