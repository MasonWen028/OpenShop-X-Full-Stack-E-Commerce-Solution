using System.Collections.Generic;

namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Contains status-related information about the order, such as its current status and available operations.
    /// </summary>
    public class StatusInfo
    {
        /// <summary>
        /// List of operations that can be performed based on the current status.
        /// </summary>
        public List<Operation> Operations { get; set; }

        /// <summary>
        /// The display text for the current status of the order (e.g., "Shipped", "Pending").
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// The type of status (e.g., order type, delivery status).
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// URL to view more details about the current status.
        /// </summary>
        public string Url { get; set; }
    }
}
