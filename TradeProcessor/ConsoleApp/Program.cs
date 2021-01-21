using System;
using System.Reflection;
using TradeProcessor.Imp;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Assembly domainAssembly = Assembly.LoadFrom("Domain.dll");
            var tradeStream = domainAssembly.GetManifestResourceStream("Domain.Trades.txt");

            var streamTradeDataProvider = new StreamTradeDataProvider(tradeStream);
            var mapper = new RecordTradeMapper();
            var logger = new ConsoleLogger();
            var validator = new TradeValidator(logger);
            var parser = new SimpleTradeParser(mapper, validator);
            var adoNetStorage = new AdoNetTradeStorage(logger);

            var tradeProcessor = new TradeProcessor.Domain.TradeProcessor(streamTradeDataProvider, parser, adoNetStorage);
            tradeProcessor.ProcessTrades();

            Console.ReadKey();
        }
    }
}
