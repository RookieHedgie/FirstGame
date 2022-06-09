using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool GameEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
   

    private void Update()
    {
   
    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        
    }

    public void GameOver()
    {
        if (GameEnded == false)
        {   
            GameEnded = true;
            Invoke("Restart", restartDelay);
            
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

