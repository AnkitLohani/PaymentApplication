using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentApp.models;
using PaymentApp.Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.TestProject
{
    [TestClass]
    public class CreateDuplicateSlipTest : TestInitializeBase
    {
        private readonly Payment payment = new Payment { Product_Type = ProductType.Physical };

        [TestMethod]
        public void CreateDuplicateSlip()
        {
            var paymentLogic = serviceProvider.GetService<IPaymentService>();

            try
            {
                var result = paymentLogic.CreateDuplicateSlip(payment);
                Assert.IsNotNull(result, "Duplicate Packingslip generated");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
