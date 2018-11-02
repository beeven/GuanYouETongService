using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace GuanYouETongService.Data
{
    public class JG47FormEntity
    {
        [JsonProperty("Creater")]
        public string Creator {get;set;}

        [JsonProperty("CreateDate")]
        public DateTime DateCreated {get;set;}

        [JsonProperty("PostValueFact")]
        public decimal PostValueFact {get;set;}

        [JsonProperty("RecvName")]
        public string RecvName {get;set;}

        [JsonProperty("RecvAddress")]
        public string RecvAddress {get;set;}

        [JsonProperty("GListInfo")]
        public List<GoodInfo> GoodsInfo {get;set;}
    }

    public class GoodInfo
    {
        [JsonProperty("GNo")]
        public string No {get;set;}

        [JsonProperty("GName")]
        public string Name {get;set;}

        [JsonProperty("GQty")]
        public decimal Quantity {get;set;}

        [JsonProperty("TradeTotal")]
        public decimal TradeTotal {get;set;}

        [JsonProperty("PostRate")]
        public decimal PostRate {get;set;}

        [JsonProperty("PostValue")]
        public decimal PostValue {get;set;}
    }
}