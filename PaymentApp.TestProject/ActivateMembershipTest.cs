using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentApp.models;
using PaymentApp.Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.TestProject
{
    [TestClass]
    public class ActivateMembershipTest : TestInitializeBase
    {
        private readonly Payment payment = new Payment { Product_Type = ProductType.Book };

        [TestMethod]
        public void ActivateMembership()
        {
            var paymentLogic = serviceProvider.GetService<IPaymentService>();
            try
            {
                var result = paymentLogic.ActivateMembership(payment);
                Assert.IsNotNull(result, "Membership is activated");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail(ex.Message);
            }

        }
    }
}
