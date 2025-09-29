    using UnityEngine;
    using UnityEngine.SceneManagement;

    public class SceneLoader : MonoBehaviour
    {
        public void LoadNextScene()
        {
            // Load the next scene in the build order
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(currentSceneIndex + 1); 
        }

        public void LoadSceneByName(string sceneName)
        {
            // Load a specific scene by its name
            SceneManager.LoadScene(Level1);
        }

        public void LoadSceneByIndex(int sceneIndex)
        {
            // Load a specific scene by its build index
            SceneManager.LoadScene(1);
        }
    }
