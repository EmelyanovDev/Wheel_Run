using Player;
using UnityEngine;

namespace UI
{
    public class RestartElements : MonoBehaviour
    {
        [SerializeField] private GameObject[] _elements;

        private void OnEnable()
        {
            PlayerHandler.PlayerDied += ActivateElements;
        }
        
        private void OnDisable()
        {
            PlayerHandler.PlayerDied -= ActivateElements;
        }

        private void ActivateElements()
        {
            foreach (var element in _elements)
                element.SetActive(true);
        }
    }
}