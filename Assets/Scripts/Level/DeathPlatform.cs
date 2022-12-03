using Player;
using UnityEngine;

namespace Level
{
    public class DeathPlatform : MonoBehaviour
    {
        private void OnTriggerExit(Collider other)
        {
            if (other.TryGetComponent(out PlayerCollision player))
            {
                player.Die();
            }
        }
    }
}
