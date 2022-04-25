using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{                                                                                   
    internal class Program
    {
        static void Main(string[] args)
        {
            //OperationManager operationManager = new OperationManager(new EfOperationDal());

            //Operation operation = new Operation() {OperationId=1, CustomerName = "Ugir", Price = 100,};

            //CaseManager casemanager = new CaseManager(new EfCaseDal());

            //operationManager.Add(operation);

            OperationTypeManager operationTypeManager = new OperationTypeManager(new EfOperationTypeDal());

            OperationType operationType = new OperationType() { OperationTypeId=1,TypeName="FTD"};

            operationTypeManager.Add(operationType);

        }
    }
}
