using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool gameEndStatus = false;
    public GameObject completeLevelUI;

    public void levelComplete()
    {
        completeLevelUI.SetActive(true);
    }

    public void gameEnd()
    {
        if (gameEndStatus == false)
        {
            gameEndStatus = true;
            Invoke("resetScene", 2f);
        }
    }

    void resetScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
