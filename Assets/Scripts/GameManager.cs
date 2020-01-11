using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float restartDelay = 1.5f;
    public float nextLevelDelay = .25f;

    public GameObject endLevelUI;
    public Score score;

    public bool GameEnded { private set; get; } = false;

    public void GameOver()
    {
        if(!GameEnded)
        {
            GameEnded = true;
            SaveScore();
            Invoke("Restart", restartDelay);
        }
    }

    void SaveScore()
    {
        if (PlayerPrefs.GetInt(SceneManager.GetActiveScene().buildIndex.ToString()) < score.score)
            PlayerPrefs.SetInt(SceneManager.GetActiveScene().buildIndex.ToString(), score.score);
    }

    internal void EndLevel()
    {
        if (!GameEnded)
        {
            GameEnded = true;
            score.LevelComplete();
            score.Update();
            SaveScore();
            Invoke("_endLevel", nextLevelDelay);
        }
    }
    internal void _endLevel()
    {
        endLevelUI.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKey("r"))
            Restart();
        if (Input.GetKey(KeyCode.Escape))
            Quit();
    }

    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    private void Quit()
    {
        Application.Quit();
    }
}
