namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Represents the pricing details of the sub-order or item.
    /// </summary>
    public class PriceInfo
    {
        /// <summary>
        /// The total price of the item in the sub-order.
        /// </summary>
        public string RealTotal { get; set; }

        /// <summary>
        /// The currency of the transaction (e.g., CNY).
        /// </summary>
        public string Currency { get; set; }

        /// <summary>
        /// The symbol for the currency (e.g., ¥).
        /// </summary>
        public string CurrencySymbol { get; set; }
    }
}
