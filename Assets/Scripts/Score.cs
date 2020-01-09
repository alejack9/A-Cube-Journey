using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Transform end;
    public Slider slider;
    public Text text;

    public GameManager gm;

    // Update is called once per frame
    void Update()
    {
        if (!gm.GameEnded)
        {
            float perc = player.position.z / end.position.z;
            slider.value = perc > 1 ? 1 : perc;
            text.text = (perc > 1 ? 100 : perc * 100).ToString("0") + " / 100";
        }
    }
}
