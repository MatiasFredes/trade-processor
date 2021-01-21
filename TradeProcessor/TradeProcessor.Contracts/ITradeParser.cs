using System.Collections.Generic;

namespace TradeProcessor.Contracts
{
    public interface ITradeParser
    {
        ICollection<TradeRecord> Parse(IEnumerable<string> lines);
    }
}