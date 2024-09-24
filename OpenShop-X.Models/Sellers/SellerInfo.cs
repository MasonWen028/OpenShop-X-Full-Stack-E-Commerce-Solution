using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace OpenShop_X.Models.Sellers
{
    /// <summary>
    /// Information about the seller, including shop details, credit level, and evaluation scores.
    /// </summary>
    public class SellerInfo
    {
        /// <summary>
        /// The unique identifier for the seller.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string SellerId { get; set; }

        /// <summary>
        /// The nickname or display name of the seller.
        /// </summary>
        public string SellerNick { get; set; }

        /// <summary>
        /// The type of seller (e.g., "B" for business).
        /// </summary>
        public string SellerType { get; set; }

        /// <summary>
        /// The credit level of the seller.
        /// </summary>
        public string CreditLevel { get; set; }

        /// <summary>
        /// URL to an icon representing the seller's credit level.
        /// </summary>
        public string CreditLevelIcon { get; set; }

        /// <summary>
        /// The unique identifier for the shop.
        /// </summary>
        public string ShopId { get; set; }

        /// <summary>
        /// The name of the seller's shop.
        /// </summary>
        public string ShopName { get; set; }

        /// <summary>
        /// The URL to the seller's shop on the PC version.
        /// </summary>
        public string PcShopUrl { get; set; }

        /// <summary>
        /// The icon representing the seller's shop.
        /// </summary>
        public string ShopIcon { get; set; }

        /// <summary>
        /// The star rating icon for the seller's shop.
        /// </summary>
        public string StartsIcon { get; set; }

        /// <summary>
        /// A list of evaluation metrics for the seller (e.g., product description accuracy, service quality).
        /// </summary>
        public List<SellerEvaluate> Evaluates { get; set; }
    }
}
