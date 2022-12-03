using UnityEngine;

namespace Camera
{
    public class SmartTracking : MonoBehaviour
    {
        [SerializeField] private Transform _target;
        [SerializeField] private float _bordersZ;
        [SerializeField] private float _downBorderY;
        [SerializeField] private float _heightIncreaseRatio;
        [Range(0, 1)] [SerializeField] private float _cameraSharpness;

        private Vector3 _trackingDistance;
        
        private float _startTargetSize;
        private float _startTrackingY;

        private void Awake()
        {
            _trackingDistance = transform.position - _target.position;
            _startTargetSize = _target.localScale.x;
            _startTrackingY = _trackingDistance.y;
        }

        private void FixedUpdate() => Track();

        private void Track()
        {
            if (_target == null) return;
            Vector3 target = GetTargetPosition();
            transform.position = Lerp(target);
        }

        private Vector3 GetTargetPosition()
        {
            float trackingY = _target.localScale.x / _startTargetSize * _startTrackingY * _heightIncreaseRatio;
            _trackingDistance.y = Mathf.Clamp(trackingY, _startTrackingY, trackingY);
            return _target.position + _trackingDistance;
        }

        private Vector3 Lerp(Vector3 target)
        {
            Vector3 position = transform.position;
            position.x = Mathf.Lerp(position.x, target.x, _cameraSharpness);
            position.y = Mathf.Lerp(position.y, Mathf.Max(_downBorderY, target.y), _cameraSharpness);
            position.z = Mathf.Lerp(position.z, Mathf.Clamp(target.z, -_bordersZ, _bordersZ), _cameraSharpness);
            return position;
        }
    }
}
