using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PaymentApp.models;
using PaymentApp.Service.ServiceInterfaces;

namespace PaymentApplication.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _payment;

        public PaymentController(IPaymentService payment)
        {
            _payment = payment;

        }

        [HttpPost]
        public bool ApplyPaymentRule(Payment payment)
        {
            bool result = false;
            switch (payment.Product_Type)
            {
                case ProductType.Physical:
                    result = _payment.GeneratePackingSlip(payment);
                    result = result && _payment.GenerateCommission(payment);
                    break;
                case ProductType.Book:
                    result = _payment.CreateDuplicateSlip(payment);
                    result = result && _payment.GenerateCommission(payment);
                    break;
                case ProductType.Membership:
                    result = _payment.ActivateMembership(payment);
                    result = result && _payment.SendEmail(payment);
                    break;
                case ProductType.MembershipUpgrade:
                    result = _payment.UpgradeMembership(payment);
                    result = result && _payment.SendEmail(payment);
                    break;
                case ProductType.LearningVideo:
                    _payment.AddFirstaidVideo(payment);
                    break;

                default: return false;

            }
            return result;


        }
    }
}
