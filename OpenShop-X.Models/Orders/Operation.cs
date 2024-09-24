namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Represents an operation or action that can be performed on the order, such as viewing details or editing.
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// The unique identifier for the operation.
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// The style of the operation (e.g., button, link).
        /// </summary>
        public string Style { get; set; }

        /// <summary>
        /// The display text for the operation.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The type of operation (e.g., navigation, action).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// The URL or action link related to the operation.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Configuration details for the operation.
        /// </summary>
        public Config Config { get; set; }
    }
}
