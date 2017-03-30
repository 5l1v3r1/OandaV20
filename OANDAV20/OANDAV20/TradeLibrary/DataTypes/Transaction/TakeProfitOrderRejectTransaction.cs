﻿namespace OANDAV20.TradeLibrary.DataTypes.Communications.Transaction
{
   public class TakeProfitOrderRejectTransaction : Transaction
   {
      public string type { get; set; }
      public long tradeID { get; set; }
      public string clientTradeID { get; set; }
      public double price { get; set; }
      public string timeInForce { get; set; }
      public string gtdTime { get; set; }
      public string triggerCondition { get; set; }
      public string reason { get; set; }
      public ClientExtensions clientExtensions { get; set; }
      public long? orderFillTransactionID { get; set; }
      public long? intendedReplacesOrderID { get; set; }
      public string rejectReason { get; set; }
   }
}
 