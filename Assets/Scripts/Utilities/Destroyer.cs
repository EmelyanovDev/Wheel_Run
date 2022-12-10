using UnityEngine;

namespace Utilities
{
    public class Destroyer : MonoBehaviour
    {
        [SerializeField] private float _destroyDelay;

        private void Start()
        {
            Destroy(gameObject, _destroyDelay);
        }
    }
}
