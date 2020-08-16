using PaymentApp.BusinessLogic.BusinessLogicInterface;
using PaymentApp.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentApp.BusinessLogic
{
    public class PaymentBusinessLogic :IPaymentBusinessLogic
    {
        public bool GeneratePackingSlip(Payment payment)
        {

            /*Code to generate slip in the required format*/
            return true;


        }
        public bool CreateDuplicateSlip(Payment payment)
        {

            /*Code to create slip in the required format*/
            return true;


        }

        public bool ActivateMembership(Payment payment)
        {
            /*Code to activate membership*/
            return true;

        }

        public bool UpgradeMembership(Payment payment)
        {

            /*code to upgrade membership*/
            return true;

        }
        public bool SendEmail(Payment payment)
        {

            /*Code to send mail*/
            return true;


        }
        public bool AddFirstaidVideo(Payment payment)
        {

            /*Code to add video to the packing slip*/
            return true;

        }

        public bool GenerateCommission(Payment payment)
        {

            /*Code to generate commission payment to the  agent*/
            return true;

        }

        public bool AddFirstaidVideo()
        {
            throw new NotImplementedException();
        }
    }
}
