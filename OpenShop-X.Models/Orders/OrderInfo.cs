namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Represents basic information about the order, such as its creation date and time.
    /// </summary>
    public class OrderInfo
    {
        /// <summary>
        /// The date the order was created.
        /// </summary>
        public string CreateDay { get; set; }

        /// <summary>
        /// The exact time the order was created.
        /// </summary>
        public string CreateTime { get; set; }

        /// <summary>
        /// The unique identifier of the order.
        /// </summary>
        public string Id { get; set; }
    }
}
