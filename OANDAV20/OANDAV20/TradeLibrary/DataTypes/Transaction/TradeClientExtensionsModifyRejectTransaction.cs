﻿namespace OANDAV20.REST20.TradeLibrary.DataTypes.Transaction
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
