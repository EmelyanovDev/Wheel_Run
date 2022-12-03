using System;
using UnityEngine;

namespace Player
{
    public class PlayerHandler : MonoBehaviour
    {
        private PlayerCollision _collision;

        public static event Action PlayerDied;

        private void Awake()
        {
            _collision = GetComponentInChildren<PlayerCollision>();
        }

        private void OnEnable() => _collision.PlayerDie += Die;

        private void OnDisable() => _collision.PlayerDie -= Die;

        private void Die()
        {
            PlayerDied?.Invoke();
        }
    }
}