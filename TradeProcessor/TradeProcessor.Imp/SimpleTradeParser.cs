using System;
using System.Collections.Generic;
using System.Text;
using TradeProcessor.Contracts;

namespace TradeProcessor.Imp
{
    public class SimpleTradeParser : ITradeParser
    {
        public SimpleTradeParser(ITradeMapper tradeMapper, ITradeValidator tradeValidator)
        {
            this.tradeMapper = tradeMapper;
            this.tradeValidator = tradeValidator;
        }

        public ICollection<TradeRecord> Parse(IEnumerable<string> tradeData)
        {
            var trades = new List<TradeRecord>();

            var lineCount = 1;
            foreach (var line in tradeData)
            {
                var fields = line.Split(new char[] { ',' });

                if (!tradeValidator.Validate(fields, lineCount))
                {
                    continue;
                }

                var trade = tradeMapper.Map(fields);

                trades.Add(trade);

                lineCount++;
            }

            return trades;
        }

        private ITradeMapper tradeMapper;
        private ITradeValidator tradeValidator;
    }
}
