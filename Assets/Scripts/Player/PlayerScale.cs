using System.Collections;
using UnityEngine;

namespace Player
{
    public class PlayerScale : MonoBehaviour
    {
        [SerializeField] private float _scaleChangeSpeed;
        [SerializeField] private Vector2 _scaleBorders;

        private PlayerCollision _collision;
        private float _scale = 1;
        private Vector3 _startScale;
        private Coroutine _coroutine;

        private void Awake()
        {
            _startScale = transform.localScale;
            _collision = GetComponentInChildren<PlayerCollision>();
        }

        private void OnEnable() => _collision.AddScale += AddScale;
        
        private void OnDisable() => _collision.AddScale -= AddScale;

        private IEnumerator ChangeScale(Vector3 targetScale)
        {
            while (transform.localScale != targetScale)
            {
                float speed = _scaleChangeSpeed * Time.fixedDeltaTime;
                transform.localScale = Vector3.MoveTowards(transform.localScale, targetScale, speed);
                yield return new WaitForFixedUpdate();
            }
        }

        private void AddScale(float value)
        {
            _scale = Mathf.Clamp(_scale + value, _scaleBorders.x, _scaleBorders.y);
            Vector3 target = _startScale * _scale;
            if(_coroutine != null)
                StopCoroutine(_coroutine);
            _coroutine = StartCoroutine(ChangeScale(target));
        }
    }
}
