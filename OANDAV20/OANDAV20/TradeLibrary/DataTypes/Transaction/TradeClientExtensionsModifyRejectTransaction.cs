﻿namespace OANDAV20.TradeLibrary.DataTypes.Communications.Transaction
{
   public class TradeClientExtensionsModifyRejectTransaction : Transaction
   {
      public string type { get; set; }
      public long tradeID { get; set; }
      public string clientTradeID { get; set; }
      public ClientExtensions tradeClientExtensionsModify { get; set; }
      public string rejectReason { get; set; }
   }
}
