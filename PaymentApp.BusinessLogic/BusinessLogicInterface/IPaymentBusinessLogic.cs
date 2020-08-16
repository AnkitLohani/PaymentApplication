using PaymentApp.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.BusinessLogic.BusinessLogicInterface
{
    public interface IPaymentBusinessLogic
    {
        bool GeneratePackingSlip(Payment payment);
        bool CreateDuplicateSlip(Payment payment);

        bool ActivateMembership(Payment payment);
        bool UpgradeMembership(Payment payment);
        bool SendEmail(Payment payment);
        bool AddFirstaidVideo();

        bool GenerateCommission(Payment payment);
    }
}
