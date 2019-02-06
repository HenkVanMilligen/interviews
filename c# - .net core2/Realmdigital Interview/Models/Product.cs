using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Models
{
    [DataContract]
    public class Product
    {
        [DataMember(Name = "Id")]
        public string Id { get; set; }

        [DataMember(Name = "BarCode")]
        public string BarCode { get; set; }

        [DataMember(Name = "ItemName")]
        public string ItemName { get; set; }

        public List<Price> ZARPriceRecords { get; set; }

        private List<Price> _priceRecords; //also known as a 'backing field'
        public List<Price> PriceRecords
        {
            get
            {
                return _priceRecords;
            }
            set
            {
                // Setting the ZAR records when the unfiltered price records are received.
                if (value != null && value.Any())
                {
                    ZARPriceRecords = PriceRecords
                        .Where(record => record.CurrencyCode == "ZAR")
                        .ToList();
                }
                _priceRecords = value;
            }
        }
        

    }
}
