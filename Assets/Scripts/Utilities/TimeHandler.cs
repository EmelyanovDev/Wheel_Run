using UnityEngine;

namespace Utilities
{
    public static class TimeHandler
    {
        public static void Pause() => Time.timeScale = 0f;
        
        public static void Resume() => Time.timeScale = 1f;
    }
}