using System.Collections.Generic;

namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Represents trade operations that can be performed on the order, such as tracking shipping or managing payment.
    /// </summary>
    public class TradeOperation
    {
        public string Style { get; set; }
        public string Text { get; set; }
        public string Type { get; set; }
        public List<SubOrder> OrderData { get; set; }
        public OrderExtra OrderExtra { get; set; }
    }
}
