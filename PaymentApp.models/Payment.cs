using System;

namespace PaymentApp.models
{
    public enum ProductType
    {
        Physical = 0,
        Book = 1,
        Membership = 2,
        MembershipUpgrade = 3,
        LearningVideo = 4,

    }
    public class Payment
    {
        public ProductType Product_Type { get; set; }
    }
}
