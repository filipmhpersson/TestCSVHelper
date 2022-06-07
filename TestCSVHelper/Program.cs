// See https://aka.ms/new-console-template for more information
using TestCSVHelper;

Console.WriteLine("Hello, World!");

var tenderBid = new TenderBid
{
    BidSubmitted = true,
    Id = "1",
    TenderId = "2"
};

var tenderBid2 = new TenderBid
{
    Id = "2",
    TenderId = "2",
    BidSubmitted = false
};

using var reader = new StreamWriter(".\\test.csv");

using var csv = new CsvHelper.CsvWriter(reader, System.Globalization.CultureInfo.InvariantCulture);
csv.Context.Configuration.HasHeaderRecord= true;
csv.Context.RegisterClassMap<TenderBidCsvMap>();

csv.WriteRecords(new List<TenderBid>() { tenderBid, tenderBid2 });