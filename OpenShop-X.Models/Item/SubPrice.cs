using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop_X.Models.Item
{
    /// <summary>
    /// Represents discount-related information and visual details about the price.
    /// </summary>
    public class SubPrice
    {
        /// <summary>
        /// Background color of the price label.
        /// </summary>
        public string PriceBgColor { get; set; }

        /// <summary>
        /// Text color of the price label.
        /// </summary>
        public string PriceColor { get; set; }

        /// <summary>
        /// The actual price after applying discounts (in minor units).
        /// </summary>
        public string PriceMoney { get; set; }

        /// <summary>
        /// Display text for the discounted price (in string format).
        /// </summary>
        public string PriceText { get; set; }

        /// <summary>
        /// Title indicating the discount type (e.g., "After Coupon").
        /// </summary>
        public string PriceTitle { get; set; }

        /// <summary>
        /// Text color of the price title.
        /// </summary>
        public string PriceTitleColor { get; set; }
    }
}
