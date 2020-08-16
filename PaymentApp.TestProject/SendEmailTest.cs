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
    public class SendEmailTest : TestInitializeBase
    {
        private readonly Payment payment = new Payment { Product_Type = ProductType.Book };

        [TestMethod]
        public void SendEmail()
        {
            var paymentLogic = serviceProvider.GetService<IPaymentService>();

            try
            {
                var result = paymentLogic.SendEmail(payment);
                Assert.IsNotNull(result, "Send Email to the owner");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
