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

        public int Pennies
        {
            get => CashDrawer.Pennies; 
        }

        public int Nickels
        {
            get => CashDrawer.Nickels;
        }
        
        public int Dimes
        {
            get => CashDrawer.Dimes; 
        }


        public int Quarters
        {
            get => CashDrawer.Quarters;
        }

        public int HalfDollars
        {
            get => CashDrawer.HalfDollars; 
        }

        public int DollarCents
        { 
        
            get => CashDrawer.Dollars;
        }

        public int Ones
        {
            get => CashDrawer.Ones;
        }

        public int TwoDollars
        {
            get => CashDrawer.Twos;
        }

        public int FiveDollars
        {
            get => CashDrawer.Fives;
        }

        public int TenDollars
        {
            get => CashDrawer.Tens;
        }

        public int TwentyDollars
        {
            get => CashDrawer.Twenties;
        }

        public int FiftyDollars
        {
            get => CashDrawer.Fifties;
        }

        public int HundredDollars
        {
            get => CashDrawer.Hundreds;
        }
    }
}
