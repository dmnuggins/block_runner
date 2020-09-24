using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text score;
    int scoreTicker = 0;
    private void Update()
    {           
        scoreTicker += (int)(Time.timeSinceLevelLoad);
        score.text = scoreTicker.ToString("0");
    }
}
