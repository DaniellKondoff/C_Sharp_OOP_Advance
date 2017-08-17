using RecyclingStation.BisinessLayer.Contracts.Core;
using RecyclingStation.BisinessLayer.Contracts.Factories;
using RecyclingStation.BisinessLayer.Contracts.IO;
using RecyclingStation.BisinessLayer.Core;
using RecyclingStation.BisinessLayer.Factories;
using RecyclingStation.BisinessLayer.IO;
using RecyclingStation.WasteDisposal;
using RecyclingStation.WasteDisposal.Interfaces;
using System;
using System.Collections.Generic;

namespace RecyclingStation
{
    public class RecyclingStationMain
    {
        public static void Main()
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();


            IStrategyHolder strategyHolder = new StrategyHolder(new Dictionary<Type,IGarbageDisposalStrategy>());
            IGarbageProcessor garbageProcessor = new GarbageProcessor(strategyHolder);
            IWasteFactory wasteFactory = new WasteFactory();

            IRecyclingStation recyclingStation = new RecyclingManager(garbageProcessor,wasteFactory);
            IEngine engine = new Engine(reader,writer,recyclingStation);

            engine.Run();
        }
    }
}
