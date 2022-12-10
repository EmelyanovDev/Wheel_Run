using System;
using Save;

namespace Money
{
    public static class Wallet
    {
        private static int _moneyCount;

        public static Action<int> MoneyChanged;

        public static int InitMoney()
        {
            _moneyCount = SaveHandler.GetMoneyCount();
            return _moneyCount;
        }

        public static void AddCoin()
        {
            _moneyCount++;
            SaveHandler.SaveMoneyCount(_moneyCount);
            MoneyChanged?.Invoke(_moneyCount);
        }
    }
}