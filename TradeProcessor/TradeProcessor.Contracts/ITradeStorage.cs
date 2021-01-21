
using System.Collections.Generic;

namespace TradeProcessor.Contracts
{
    public interface ITradeStorage
    {
        void Persist(ICollection<TradeRecord> trades);
    }
}