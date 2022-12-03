using UnityEngine.SceneManagement;

namespace Utilities
{
    public static class SceneLoader
    {
        public static void RestartScene()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}