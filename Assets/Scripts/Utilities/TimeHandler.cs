using Player;
using UnityEngine;

namespace Utilities
{
    public class TimeHandler : MonoBehaviour
    {
        private void Start() => Pause();

        private void OnEnable()
        {
            PlayerHandler.PlayerDied += Pause;
        }
        
        private void OnDisable()
        {
            PlayerHandler.PlayerDied -= Pause;
        }
        
        public static void Pause() => Time.timeScale = 0f;
        
        public static void Resume() => Time.timeScale = 1f;
    }
}