using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiAdvertDeliveryDiscountGetResponse.
    /// </summary>
    public class KoubeiAdvertDeliveryDiscountGetResponse : AlipayResponse
    {
        /// <summary>
        /// 广告推荐的商品信息列表，个数小于等于请求中参数“size”个数
        /// </summary>
        [JsonProperty("discounts")]
        public DiscountInfo Discounts { get; set; }

        /// <summary>
        /// 本次推荐的唯一标识， 此字段需回传
        /// </summary>
        [JsonProperty("recommend_id")]
        public string RecommendId { get; set; }
    }
}
