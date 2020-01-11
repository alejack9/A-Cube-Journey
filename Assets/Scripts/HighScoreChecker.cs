using UnityEngine;
using UnityEngine.UI;

public class HighScoreChecker : MonoBehaviour
{
    public int levelBuildNumber;
    public void Start()
    {
        GetComponent<Text>().text = PlayerPrefs.GetInt(levelBuildNumber.ToString()).ToString() + "%";
    }
}
