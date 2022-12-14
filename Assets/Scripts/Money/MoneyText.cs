using TMPro;
using UnityEngine;

namespace Money
{
    [RequireComponent(typeof(TMP_Text))]
    
    public class MoneyText : MonoBehaviour
    {
        private TMP_Text _text;

        private void Awake()
        {
            _text = GetComponent<TMP_Text>();
            _text.text = Wallet.InitMoney().ToString();
        }

        private void OnEnable()
        {
            Wallet.MoneyChanged += UpdateText;
        }

        private void OnDisable()
        {
            Wallet.MoneyChanged -= UpdateText;
        }

        private void UpdateText(int moneyCount)
        {
            _text.text = moneyCount.ToString();
        }
    }
}