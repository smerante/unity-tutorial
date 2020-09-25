using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    bool gameOver = false;
    public float restartTimer = 2f;
    public GameObject completeLevelUi;
    public PlayerMovement playerMovement;

    public void CompleteLevel()
    {
        Debug.Log("Complete Level");
        playerMovement.enabled = false;
        completeLevelUi.SetActive(true);
    }
    // Start is called before the first frame update
    public void EndGame()
    {
        if (this.gameOver == false)
        {
            Debug.Log("Game Over");
            this.gameOver = true;
            Invoke("Restart", restartTimer);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
