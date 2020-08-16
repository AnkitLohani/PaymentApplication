﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentApp.models;
using PaymentApp.Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.TestProject
{
    [TestClass]
    public class CommisionPaymentTest : TestInitializeBase
    {
        private readonly Payment payment = new Payment { Product_Type = ProductType.Book };
        [TestMethod]
        public void ComissionPayment()
        {
            var paymentLogic = serviceProvider.GetService<IPaymentService>();
            try
            {
                var result = paymentLogic.GenerateCommission(payment);
                Assert.IsNotNull(result, "Commission to the agent is given");
            }
            catch (InvalidOperationException ex)
            {
                Assert.Fail(ex.Message);
            }

        }
    }
}