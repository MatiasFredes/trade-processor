using System;
using System.Collections.Generic;
using System.Text;
using TradeProcessor.Contracts;

namespace TradeProcessor.Imp
{
    public class TradeValidator : ITradeValidator
    {
        public TradeValidator(ILogger logger)
        {
            this.logger = logger;
        }

        public bool Validate(string[] fields, int currentLines)
        {
            if (fields.Length != 3)
            {
                logger.LogWarning($"WARN: Line {currentLines} malformed. Only {fields.Length} field(s) found.");
            }

            if (fields[0].Length != 6)
            {
                logger.LogWarning($"WARN: Trade currencies on line {currentLines} malformed: '{fields[0]}'");
            }

            int tradeAmount;
            if (!int.TryParse(fields[1], out tradeAmount))
            {
                logger.LogWarning($"WARN: Trade amount on line {currentLines} not a valid integer: '{fields[1]}'");
            }

            decimal tradePrice;
            if (!decimal.TryParse(fields[2], out tradePrice))
            {
                logger.LogWarning($"WARN: Trade price on line {currentLines} not a valid decimal: '{fields[2]}'");
            }

            return true;
        }

        private ILogger logger;
    }
}
