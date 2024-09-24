using System.Collections.Generic;
using System.IO;

namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Represents a sub-order, which is part of the main order.
    /// Includes item information, pricing, and operations.
    /// </summary>
    public class SubOrder
    {
        /// <summary>
        /// The unique identifier for the sub-order.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// Information about the item included in this sub-order.
        /// </summary>
        public ItemInfo ItemInfo { get; set; }

        /// <summary>
        /// Operations that can be performed on this sub-order.
        /// </summary>
        public List<Operation> Operations { get; set; }

        /// <summary>
        /// Pricing details for this sub-order.
        /// </summary>
        public PriceInfo PriceInfo { get; set; }

        /// <summary>
        /// Quantity of the item in this sub-order.
        /// </summary>
        public QuantityInfo Quantity { get; set; }
    }
}
