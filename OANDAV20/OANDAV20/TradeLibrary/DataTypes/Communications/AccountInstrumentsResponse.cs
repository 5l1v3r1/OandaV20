﻿using System.Collections.Generic;

namespace OANDAV20.REST20.TradeLibrary.DataTypes.Communications
{
   public class AccountInstrumentsResponse
   {
      public List<Instrument.Instrument> instruments;
      public long lastTransactionID;
   }
}
