using Player;
using UnityEngine;

namespace Money
{
    public class Coin : MonoBehaviour
    {
        [SerializeField] private ParticleSystem _takingEffect;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent(out PlayerCollision playerCollision))
            {
                Taking(playerCollision);
            }
        }

        private void Taking(PlayerCollision player)
        {
            player.AddCoin();
            Instantiate(_takingEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}