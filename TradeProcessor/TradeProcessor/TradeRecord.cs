namespace Domain
{
    internal class TradeRecord
    {
        public string SourceCurrency { get; internal set; }
        public string DestinationCurrency { get; internal set; }
        public float Lots { get; internal set; }
        public decimal Price { get; internal set; }
    }
}