using System;
using Money;
using UnityEngine;

namespace Player
{
    public class PlayerCollision : MonoBehaviour
    {
        public event Action<float> AddScale;
        public event Action PlayerDie;

        public void SizeBoost(float scaleAdding) => AddScale?.Invoke(scaleAdding);

        public void Die() => PlayerDie?.Invoke();

        public void AddCoin() => Wallet.AddCoin();
    }
}