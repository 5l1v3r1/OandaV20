﻿namespace OANDAV20.TradeLibrary.DataTypes.Communications.Transaction
{
   public class MarketOrderTransaction : Transaction
   {
      public string type { get; set; }
      public string instrument { get; set; }
      public double units { get; set; }
      public string timeInForce { get; set; }
      public double? priceBound { get; set; }
      public string positionFill { get; set; }
      public MarketOrderTradeClose tradeClose { get; set; }
      public MarketOrderPositionCloseout longPositionCloseout { get; set; }
      public MarketOrderPositionCloseout shortPositionCloseout { get; set; }
      public MarketOrderMarginCloseout marginCloseout { get; set; }
      public MarketOrderDelayedTradeClose delayedTradeClose { get; set; }
      public string reason { get; set; }
      public ClientExtensions clientExtensions { get; set; }
      public TakeProfitDetails takeProfitOnFill { get; set; }
      public StopLossDetails stopLossOnFill { get; set; }
      public TrailingStopLossDetails trailingStopLossOnFill { get; set; }
      public ClientExtensions tradeClientExtensions { get; set; }
   }
}
