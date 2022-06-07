using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCSVHelper
{

    public class TenderBidCsvMap : ClassMap<TenderBid>
    {
        public TenderBidCsvMap()
        {

            AutoMap(CultureInfo.InvariantCulture)¨;

        }
    }
    public class TenderBid
    {
        public string Id { get; set; }
        public string TenderId { get; set; }
        public bool BidSubmitted { get; set; }
        public List<TenderBidPrice> Price { get; set; }

    }

    public class TenderBidPrice
    {
        public Guid TenderPriceId { get; set; }
        public string Price { get; set; }
        public string Reservation { get; set; }
    }
}
