
namespace OpenShop_X.Models.Payments
{
    /// <summary>
    /// Represents the payment information of the order, including total fees and payment methods.
    /// </summary>
    public class PayInfo
    {
        /// <summary>
        /// The actual amount paid by the customer.
        /// </summary>
        public string ActualFee { get; set; }

        /// <summary>
        /// The fee for credit-based payment methods, if applicable.
        /// </summary>
        public string CreditGoFee { get; set; }

        /// <summary>
        /// A list of icons representing payment-related information.
        /// </summary>
        public List<Icon> Icons { get; set; }

        /// <summary>
        /// A list of fees related to shipping and other post-payment costs.
        /// </summary>
        public List<PostFee> PostFees { get; set; }

        /// <summary>
        /// The currency used for the payment (e.g., CNY).
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The currency symbol (e.g., ¥).
        /// </summary>
        public string CurrencySymbol { get; set; }
    }
}
