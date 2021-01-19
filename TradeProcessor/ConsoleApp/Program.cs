using Domain;
using System;
using System.Reflection;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Assembly domainAssembly = Assembly.LoadFrom("Domain.dll");
            var tradeStream = domainAssembly.GetManifestResourceStream("Domain.Trades.txt");

            var tradeProcessor = new TradeProcessor();
            tradeProcessor.ProcessTrades(tradeStream);

            Console.ReadKey();
        }
    }
}
