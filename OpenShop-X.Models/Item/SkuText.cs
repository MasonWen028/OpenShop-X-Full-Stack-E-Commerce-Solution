namespace OpenShop_X.Models.Item
{
    /// <summary>
    /// Represents the SKU (Stock Keeping Unit) details of an item, such as its type, price, and discount details.
    /// </summary>
    public class SkuText
    {
        /// <summary>
        /// The name of the SKU attribute (e.g., "Size", "Color").
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The specific value of that attribute (e.g., "XL", "Red").
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Indicates if the SKU attribute is visible to customers.
        /// </summary>
        public string Visible { get; set; }

        /// <summary>
        /// Indicates if adding this SKU to the cart is possible.
        /// </summary>
        public bool AddCartCheck { get; set; }

        /// <summary>
        /// Displays logistics information like expected delivery times.
        /// </summary>
        public string LogisticsTime { get; set; }

        /// <summary>
        /// Displays the price of the item (in string format).
        /// </summary>
        public string PriceText { get; set; }

        /// <summary>
        /// The actual price of the item in minor units (e.g., cents).
        /// </summary>
        public string PriceMoney { get; set; }

        /// <summary>
        /// Shows the current available quantity of the item.
        /// </summary>
        public string Quantity { get; set; }

        /// <summary>
        /// Display value for item quantity.
        /// </summary>
        public string QuantityDisplayValue { get; set; }

        /// <summary>
        /// A message displaying the stock status (e.g., "In Stock").
        /// </summary>
        public string QuantityText { get; set; }

        /// <summary>
        /// Details about the price after applying discounts.
        /// </summary>
        public SubPrice SubPrice { get; set; }
    }
}
