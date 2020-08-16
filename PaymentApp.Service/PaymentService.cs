using PaymentApp.BusinessLogic.BusinessLogicInterface;
using PaymentApp.models;
using PaymentApp.Service.ServiceInterfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.Service
{
    public class PaymentService :IPaymentService
    {
        private readonly IPaymentBusinessLogic _paymentBusinessLogic;

        public PaymentService(IPaymentBusinessLogic paymentService)
        {

            _paymentBusinessLogic = paymentService;
        }

        public bool GeneratePackingSlip(Payment payment)
        {
            var paymentslip = _paymentBusinessLogic.GeneratePackingSlip(payment);
            return paymentslip;
        }
        public bool CreateDuplicateSlip(Payment payment)
        {
            var duplicateSlip = _paymentBusinessLogic.CreateDuplicateSlip(payment);
            return duplicateSlip;
        }

        public bool ActivateMembership(Payment payment)
        {
            var activateMember = _paymentBusinessLogic.ActivateMembership(payment);
            return activateMember;
        }
        public bool UpgradeMembership(Payment payment)
        {
            var memberUpgrade = _paymentBusinessLogic.ActivateMembership(payment);
            return memberUpgrade;
        }
        public bool SendEmail(Payment payment)
        {
            throw new NotImplementedException();

        }
        public bool AddFirstaidVideo(Payment payment)
        {
            throw new NotImplementedException();
        }

        public bool GenerateCommission(Payment payment)
        {
            throw new NotImplementedException();
        }
    }
}
