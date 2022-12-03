using UI;
using UnityEngine;

namespace Player
{
    [RequireComponent(typeof(Rigidbody))]
    
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField] private float _moveSpeed;
        [SerializeField] private float _sidewaysSpeed;

        private Rigidbody _rigidbody;

        private void Awake()
        {
            _rigidbody = GetComponent<Rigidbody>();
        }

        private void OnEnable()
        {
            MovingPanel.PanelDrag += MoveSideways;
        }
        
        private void OnDisable()
        {
            MovingPanel.PanelDrag -= MoveSideways;
        }

        private void FixedUpdate() => Move();

        private void Move()
        {
            var velocity = _rigidbody.velocity;
            velocity.x = _moveSpeed;
            _rigidbody.velocity = velocity;
        }

        private void MoveSideways(float value)
        {
            var pos = _rigidbody.position;
            pos.z += value * _sidewaysSpeed * Time.deltaTime;
            _rigidbody.position = pos;
        }
    }
}