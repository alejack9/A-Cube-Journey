using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1.5f;
    public float nextLevelDelay = .25f;

    public GameObject endLevelUI;

    public bool GameEnded { private set; get; } = false;

    public void GameOver()
    {
        if(!GameEnded)
        {
            GameEnded = true;
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().buildIndex.ToString() + "_" + player.location.z);
            Invoke("Restart", restartDelay);
        }
    }

    internal void EndLevel()
    {
        Invoke("_endLevel", nextLevelDelay);
    }
    internal void _endLevel()
    {
        if (!GameEnded)
            endLevelUI.SetActive(true);
    }

    void Update()
    {
        if(Input.GetKey("r"))
            Restart();
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
