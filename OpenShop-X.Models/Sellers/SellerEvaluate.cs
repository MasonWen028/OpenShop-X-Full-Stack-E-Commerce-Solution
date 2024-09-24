using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenShop_X.Models.Sellers
{
    /// <summary>
    /// Represents an evaluation score for a specific aspect of the seller, such as product description or service.
    /// </summary>
    public class SellerEvaluate
    {
        /// <summary>
        /// The level of the evaluation (e.g., 1 for "High").
        /// </summary>
        public string Level { get; set; }

        /// <summary>
        /// Display text for the level of evaluation (e.g., "High").
        /// </summary>
        public string LevelText { get; set; }

        /// <summary>
        /// The numerical score for this aspect (e.g., 4.8).
        /// </summary>
        public string Score { get; set; }

        /// <summary>
        /// The title of the evaluation aspect (e.g., "Product Description").
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The type of evaluation (e.g., "desc" for product description, "serv" for service).
        /// </summary>
        public string Type { get; set; }
    }
}
