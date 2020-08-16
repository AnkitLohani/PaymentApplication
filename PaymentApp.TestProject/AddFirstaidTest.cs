using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentApp.models;
using PaymentApp.Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.TestProject
{
    [TestClass]
    public class AddFirstaidTest : TestInitializeBase
    {
        private readonly Payment payment = new Payment { Product_Type = ProductType.Book };
        [TestMethod]
        public void AddFirstaid()
        {
            var paymentLogic = serviceProvider.GetService<IPaymentService>();
            try
            {
                var result = paymentLogic.AddFirstaidVideo(payment);
                Assert.IsNotNull(result, "FirstAid  video is added");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}
