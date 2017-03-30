﻿using System.Collections.Generic;

namespace OANDAV20.TradeLibrary.DataTypes.Communications.Transaction
{
   public class OrderFillTransaction : Transaction
   {
      public string type { get; set; }
      public long orderID { get; set; }
      public string clientOrderID { get; set; }
      public string instrument { get; set; }
      public double units { get; set; }
      public double price { get; set; }
      public string reason { get; set; }
      public double pl { get; set; }
      public double financing { get; set; }
      public double accountBalance { get; set; }
      public TradeOpen tradeOpened { get; set; }
      public List<TradeReduce> tradesClosed { get; set; }
      public TradeReduce tradeReduced { get; set; }
   }
}
