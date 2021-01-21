using System.Collections.Generic;

namespace TradeProcessor.Contracts
{
    public interface ITradeValidator
    {
        bool Validate(string[] fields, int lineCount);
    }
}