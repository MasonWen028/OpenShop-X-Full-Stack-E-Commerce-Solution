namespace OpenShop_X.Models.Orders
{
    /// <summary>
    /// Metadata about the order, such as currency, batch details, and trade status.
    /// </summary>
    public class ExtraInfo
    {
        public string BatchGroup { get; set; }
        public string BatchGroupTips { get; set; }
        public int BatchMaxCount { get; set; }
        public int BizType { get; set; }
        public string Currency { get; set; }
        public string CurrencySymbol { get; set; }
        public long Id { get; set; }
        public bool InHold { get; set; }
        public bool IsShowSellerService { get; set; }
        public bool NeedDisplay { get; set; }
        public string TradeStatus { get; set; }
        public bool Visibility { get; set; }
    }
}
