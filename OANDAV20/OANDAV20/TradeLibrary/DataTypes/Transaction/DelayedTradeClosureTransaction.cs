﻿using System.Collections.Generic;

namespace OANDAV20.TradeLibrary.DataTypes.Transaction
{
   public class DelayedTradeClosureTransaction : Transaction
   {
      public string type { get; set; }
      public string reason { get; set; }
      public List<long> tradeIDs { get; set; }
   }
}
