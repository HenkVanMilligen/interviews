using System;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Price
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "SellingPrice")]
        public string SellingPrice { get; set; }

        [DataMember(Name = "CurrencyCode")]
        public string CurrencyCode { get; set; }
    }
}
