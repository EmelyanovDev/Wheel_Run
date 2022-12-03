using UnityEngine;

namespace UI
{
    public class ShopButton : MonoBehaviour
    {
        private void OnEnable()
        {
            MovingPanel.PanelDrag += Deactivate;
        }
        
        private void OnDisable()
        {
            MovingPanel.PanelDrag -= Deactivate;
        }

        private void Deactivate(float f)
        {
            gameObject.SetActive(false);
        }
    }
}