using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Welcome : MonoBehaviour
{
    public void ResetStats()
    {
        PlayerPrefs.DeleteAll();
        HighScoreChecker[] objs = FindObjectsOfType<HighScoreChecker>();
        foreach(var obj in objs)
            obj.Start();
    }

    public void Level1()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
}
