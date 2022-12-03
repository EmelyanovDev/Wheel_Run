using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    
    public class PlayerGravitation : MonoBehaviour
    {
        [SerializeField] private float _gravityAddition;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void FixedUpdate() => Gravity();

        private void Gravity()
        {
            var newVelocity = _rigidbody.velocity;
            newVelocity.y += _gravityAddition * Time.fixedDeltaTime;
            _rigidbody.velocity = newVelocity;
        }
    }
}