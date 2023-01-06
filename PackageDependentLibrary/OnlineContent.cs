using System;

namespace PackageDependentLibrary
{
    public class OnlineContent
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ContentType ContentType { get; set; }
        public string Description { get; set; }
        public DateTime OpeningDate { get; set; }
        public DateTime ClosingDate { get; set; }
        public double MonthlySubscriptionFee { get; set; }
    }
}
