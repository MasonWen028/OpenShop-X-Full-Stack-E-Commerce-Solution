using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop_X.Models.Item
{
    /// <summary>
    /// Contains information about the item included in a sub-order, such as SKU and product title.
    /// </summary>
    public class ItemInfo
    {
        /// <summary>
        /// The URL to view the item.
        /// </summary>
        public string ItemUrl { get; set; }

        /// <summary>
        /// The title or name of the item.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// List of SKU details about the item.
        /// </summary>
        public List<SkuText> SkuText { get; set; }

        /// <summary>
        /// The URL to the image of the item.
        /// </summary>
        public string Pic { get; set; }

        /// <summary>
        /// The unique identifier of the item.
        /// </summary>
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string ItemId { get; set; }

        /// <summary>
        /// URL of the product description page for PC.
        /// </summary>
        public string PcADescUrl { get; set; }

        /// <summary>
        /// QR code URL that leads to the mobile version of the item page.
        /// </summary>
        public string QrCode { get; set; }

        /// <summary>
        /// The SPU (Standard Product Unit) identifier for the item.
        /// </summary>
        public string SpuId { get; set; }

        /// <summary>
        /// Image URLs for the item.
        /// </summary>
        public List<string> Images { get; set; }

        /// <summary>
        /// A URL for a title icon related to the item.
        /// </summary>
        public string TitleIcon { get; set; }

        /// <summary>
        /// Indicates if the wireless description is used (for mobile devices).
        /// </summary>
        public bool UseWirelessDesc { get; set; }

        /// <summary>
        /// The vague count of how many units have been sold.
        /// </summary>
        public string VagueSellCount { get; set; }
    }
}

