﻿namespace OANDAV20.REST20.TradeLibrary.DataTypes.Transaction
{
   public class OrderClientExtensionsModifyTransaction : Transaction
   {
      public string type { get; set; }
      public long orderID { get; set; }
      public string clientOrderID { get; set; }
      public ClientExtensions clientExtensionsModify { get; set; }
      public ClientExtensions tradeClientExtensionsModify { get; set; }
   }
}
