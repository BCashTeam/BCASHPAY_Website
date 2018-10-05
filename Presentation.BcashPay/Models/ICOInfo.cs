using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Presentation.BcashPay.v2.Models
{
    public class ICOInfo
    {
        public int ID { set; get; }
        public int CurrencyID { set; get; }
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:ss.sssZ")]
        public DateTime ICODate { set; get; }
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:ss.sssZ")]
        public DateTime EndICODate { set; get; }
        [JsonConverter(typeof(CustomDateTimeConverter), "yyyy-MM-ddTHH:mm:ss.sssZ")]
        public DateTime Today { set; get; }
        public decimal TotalQuantity { set; get; }
        public decimal SellQuantity { set; get; }
        public decimal USDPrice { set; get; }
        public decimal MaximumQuantityPerUser { set; get; }
        public decimal MinOrderQuantity { set; get; }
        public decimal AvailableQuantity { set; get; }
        public decimal AvailableQuantityUser { set; get; }
        public decimal PriceInBTC { set; get; }
        public decimal PriceInETH { set; get; }
        public decimal TotalICOQuantity { set; get; }
        public decimal CurrentICOQuantity { set; get; }
    }
}