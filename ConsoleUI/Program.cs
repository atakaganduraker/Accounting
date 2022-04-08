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
            OperationManager operationManager = new OperationManager(new EfOperationDal());
            
            Operation operation = new Operation() {OperationId=1, CustomerName = "Ugir", Price = 100};

            operationManager.Add(operation);

        }
    }
}
