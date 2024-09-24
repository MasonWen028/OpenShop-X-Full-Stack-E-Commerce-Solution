namespace OpenShop_X.Models.Payments
{
    /// <summary>
    /// Represents an icon related to the payment or order.
    /// </summary>
    public class Icon
    {
        /// <summary>
        /// The title of the icon's link.
        /// </summary>
        public string LinkTitle { get; set; }

        /// <summary>
        /// The URL of the icon's link.
        /// </summary>
        public string LinkUrl { get; set; }

        /// <summary>
        /// The type of the icon (e.g., payment method type).
        /// </summary>
        public int Type { get; set; }

        /// <summary>
        /// The URL to the icon image.
        /// </summary>
        public string Url { get; set; }
    }
}
