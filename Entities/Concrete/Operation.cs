using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Operation:IEntity
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public int OperationTypeId { get; set; }
        public decimal Price { get; set; }
        public int CurrencyId { get; set; }
        public bool IsActive { get; set; }
        public decimal Commission { get; set; }
        public decimal Net { get; set; }
        public DateTime OperationTime { get; set; }
        public int CompanyId { get; set; }
        public string Note { get; set; }
        public int OperationDetailId { get; set; }


    }
}
