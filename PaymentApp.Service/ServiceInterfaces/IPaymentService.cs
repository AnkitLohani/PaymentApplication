using PaymentApp.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.Service.ServiceInterfaces
{
    public interface IPaymentService
    {
        bool GeneratePackingSlip(Payment payment);
        bool CreateDuplicateSlip(Payment payment);

        bool ActivateMembership(Payment payment);
        bool UpgradeMembership(Payment payment);
        bool SendEmail(Payment payment);
        bool AddFirstaidVideo(Payment payment);

        bool GenerateCommission(Payment payment);


    }
}
