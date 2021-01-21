using System.Collections.Generic;
using TradeProcessor.Contracts;

namespace TradeProcessor.Contracts
{
    public interface ITradeMapper
    {
        TradeRecord Map(string[] fields);
    }
}