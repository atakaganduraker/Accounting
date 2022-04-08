using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Case:IEntity
    {
        public int CaseId { get; set; }
        public string CaseName { get; set; }
        public bool IsActive { get; set; }

    }
}
