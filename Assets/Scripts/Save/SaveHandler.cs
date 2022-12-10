using UnityEngine;

namespace Save
{
    public static class SaveHandler
    {
        private const string MoneyKey = "MoneyCount";

        public static int GetMoneyCount()
        {
            if (PlayerPrefs.HasKey(MoneyKey))
                return PlayerPrefs.GetInt(MoneyKey);
            return 0;
        }

        public static void SaveMoneyCount(int moneyCount)
        {
            PlayerPrefs.SetInt(MoneyKey, moneyCount);
        }
    }
}