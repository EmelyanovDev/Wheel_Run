using UnityEngine;
using UnityEngine.EventSystems;
using Utilities;

namespace UI
{
    public class RestartButton : MonoBehaviour, IPointerClickHandler
    {
        public void OnPointerClick(PointerEventData eventData)
        {
            SceneLoader.RestartScene();
        }
    }
}