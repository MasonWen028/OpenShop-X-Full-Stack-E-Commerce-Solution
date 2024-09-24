namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Configuration details for the operation, such as the kind of operation and its styling.
    /// </summary>
    public class Config
    {
        /// <summary>
        /// The type or category of the operation (e.g., "edit", "view").
        /// </summary>
        public string Kind { get; set; }

        /// <summary>
        /// The style associated with the operation.
        /// </summary>
        public string Style { get; set; }
    }
}
