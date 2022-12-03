using System;
using UnityEngine;
using UnityEngine.EventSystems;
using Utilities;

namespace UI
{
    public class MovingPanel : MonoBehaviour, IDragHandler
    {
        private bool _isClicked;
        
        public static event Action<float> PanelDrag;

        public void OnDrag(PointerEventData eventData)
        {
            ResumeGame();
            PanelDrag?.Invoke(-eventData.delta.x);
        }

        private void ResumeGame()
        {
            if (_isClicked) return;
            TimeHandler.Resume();
            _isClicked = true;
        }
    }
}
