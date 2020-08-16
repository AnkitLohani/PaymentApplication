using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentApp.models;
using PaymentApp.Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.TestProject
{
    [TestClass]
    public class UpgradeMembershipTest : TestInitializeBase
    {
        private readonly Payment payment = new Payment { Product_Type = ProductType.Physical };
        [TestMethod]
        public void UpgradeMembership()
        {
            var paymentLogic = serviceProvider.GetService<IPaymentService>();
            try
            {
                var result = paymentLogic.UpgradeMembership(payment);
                Assert.IsNotNull(result, "Membership is upgraded");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
