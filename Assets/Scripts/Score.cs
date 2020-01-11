using System;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Transform end;
    public Slider slider;

    public int score => Mathf.RoundToInt(_score * 100);
    private float _score;

    public GameManager gameManager;

    // Update is called once per frame
    public void Update()
    {
        if (!gameManager.GameEnded)
        {
            float perc = player.position.z / end.position.z;
            _score = perc > 1 ? 1 : perc;
        }
        slider.value = _score;
        GetComponent<Text>().text = score + " / 100";
    }

    public void LevelComplete()
    {
        _score = 1;
    }
}
