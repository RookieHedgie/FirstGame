
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete : MonoBehaviour
{

    void LevelEnd()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
