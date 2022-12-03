using Player;
using UnityEngine;

namespace Level
{
    public class SizeBoost : MonoBehaviour
    {
        [SerializeField] private float _scaleAdding;

        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerCollision player))
            {
                player.SizeBoost(_scaleAdding);
                Destroy(gameObject);
            }
        }
    }
}