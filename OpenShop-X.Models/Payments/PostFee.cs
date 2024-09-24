namespace OpenShop_X.Models.Payments
{
    /// <summary>
    /// Represents post-related fees such as shipping costs.
    /// </summary>
    public class PostFee
    {
        /// <summary>
        /// The prefix to the post fee (e.g., "Includes shipping").
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// The suffix to the post fee (e.g., currency symbol).
        /// </summary>
        public string Suffix { get; set; }

        /// <summary>
        /// The value of the post fee.
        /// </summary>
        public string Value { get; set; }
    }
}
