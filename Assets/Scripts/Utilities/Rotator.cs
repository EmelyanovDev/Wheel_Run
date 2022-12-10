using UnityEngine;

namespace Utilities
{
    public class Rotator : MonoBehaviour
    {
        [SerializeField] private Vector3 _rotation;

        private void FixedUpdate() => Rotate();

        private void Rotate()
        {
            Vector3 rotate = _rotation * Time.fixedDeltaTime;
            transform.Rotate(rotate);
        }
    }
}
