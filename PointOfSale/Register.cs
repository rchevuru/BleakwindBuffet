using System;
using System.Collections.Generic;
using System.Text;
using RoundRegister;

namespace PointOfSale
{
    class Register
    {
        public CardTransactionResult Checking(double total)
        {
            return CardReader.RunCard(total);
        }
    }
}
