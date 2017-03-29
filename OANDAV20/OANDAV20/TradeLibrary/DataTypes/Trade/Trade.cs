﻿using OANDAV20.REST20.TradeLibrary.DataTypes.Order;
using OANDAV20.REST20.TradeLibrary.DataTypes.Transaction;
using System.Collections.Generic;

namespace OANDAV20.REST20.TradeLibrary.DataTypes.Trade
{
   public class Trade
   {
      public long id { get; set; }
      public string instrument { get; set; }
      public double price { get; set; }
      public string openTime { get; set; }
      public string state { get; set; }
      public int initialUnits { get; set; }
      public int currentUnits { get; set; }
      public double realizedPL { get; set; }
      public double unrealizedPL { get; set; }
      public double averageClosePrice { get; set; }
      public List<long> closingTransactionIDs { get; set; }
      public double financing { get; set; }
      public string closeTime { get; set; }
      public ClientExtensions clientExtensions { get; set; }
      public TakeProfitOrder takeProfitOrder { get; set; }
      public StopLossOrder stopLossOrder { get; set; }
      public TrailingStopLossOrder trailingStopLossOrder { get; set; }
   }
}
